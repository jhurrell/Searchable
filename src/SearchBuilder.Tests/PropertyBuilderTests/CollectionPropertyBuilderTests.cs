using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchBuilder.PropertyBuilders.Collection;

namespace SearchBuilder.Tests.PropertyBuilderTests
{
	[TestClass]
	public class CollectionPropertyBuilderTests
	{
		protected CollectionPropertyBuilder Tester;

		[TestInitialize]
		public void TestInitialize()
		{
			Tester = new SearchBuilder<SampleClass>().CanSearch(s => s.ObjectArray) as CollectionPropertyBuilder;
		}

		[TestClass]
		public class IncludeTests : CollectionPropertyBuilderTests
		{
			[TestMethod]
			public void Include_ReturnType_IsCollectionPropertyBuilder()
			{
				var result = Tester.Include(CollectionOperators.ContainsAllOf);
				Assert.IsInstanceOfType(result, typeof(CollectionPropertyBuilder));
			}

			[TestMethod]
			public void Include_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Include(CollectionOperators.ContainsAllOf);
					Tester.Include(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'ContainsAllOf'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_CallingTwiceWithChainingForSameOprtator_RaisesException()
			{
				try
				{
					Tester
						.Include(CollectionOperators.ContainsAllOf)
						.Include(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'ContainsAllOf'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_AndExclude_RaisesException()
			{
				try
				{
					Tester.Include(CollectionOperators.ContainsAllOf);
					Tester.Exclude(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Cannot mix Include() and Exclude().", ex.Message);
				}
			}

			[TestMethod]
			public void Include_CallingOnce_ResetsOperatorsCollection()
			{
				var countBefore = Tester.Operators.Count;
				Tester.Include(CollectionOperators.ContainsAllOf);
				var countAfter = Tester.Operators.Count;

				Assert.AreEqual(CollectionOperatorSupport.GetOperators().Count, countBefore);
				Assert.AreEqual(1, countAfter);
			}

			[TestMethod]
			public void Include_ForProperties_IncludesOnlyThosePropertiesInPropertiesCollection()
			{
				string[] expected = { "ContainsAllOf", "ContainsNoneOf", "ContainsOneOf" };
				Tester
					.Include(CollectionOperators.ContainsAllOf)
					.Include(CollectionOperators.ContainsNoneOf)
					.Include(CollectionOperators.ContainsOneOf);

				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.AreEqual(expected, actual);
			}
		}

		[TestClass]
		public class ExcludeTests : CollectionPropertyBuilderTests
		{
			[TestMethod]
			public void Exclude_ReturnType_IsCollectionPropertyBuilder()
			{
				var result = Tester.Exclude(CollectionOperators.ContainsAllOf);
				Assert.IsInstanceOfType(result, typeof(CollectionPropertyBuilder));
			}

			[TestMethod]
			public void Exclude_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Exclude(CollectionOperators.ContainsAllOf);
					Tester.Exclude(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'ContainsAllOf'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_CallingTwiceWithChainingForSameOperator_RaisesException()
			{
				try
				{
					Tester
						.Exclude(CollectionOperators.ContainsAllOf)
						.Exclude(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'ContainsAllOf'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_AndInclude_RaisesException()
			{
				try
				{
					Tester.Exclude(CollectionOperators.ContainsAllOf);
					Tester.Include(CollectionOperators.ContainsAllOf);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Cannot mix Include() and Exclude().", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_ForOperators_ExcludesOnlyThoseOperators()
			{
				Tester.Exclude(CollectionOperators.ContainsAllOf);
				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.DoesNotContain(actual, "ContainsAllOf");
			}
		}

		[TestClass]
		public class IsValidTests : CollectionPropertyBuilderTests
		{
			[TestMethod]
			public void IsValid_WhenSingleOperatorAndNotIsValid_IsFalse()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.ObjectArray) as CollectionPropertyBuilder;
				Tester.Include(CollectionOperators.ContainsOneOf);

				Assert.IsFalse(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenSingleOperatorAndIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.ObjectArray) as CollectionPropertyBuilder;
				Tester.Include(CollectionOperators.ContainsOneOf);
				Tester["ContainsOneOf"].Values = new List<object> { "A", "B", "C" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndAllIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.ObjectArray) as CollectionPropertyBuilder;
				Tester.Include(CollectionOperators.ContainsOneOf);
				Tester["ContainsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(CollectionOperators.ContainsNoneOf);
				Tester["ContainsNoneOf"].Values = new List<object> { "X", "Y", "Z" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndOneNotIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.ObjectArray) as CollectionPropertyBuilder;
				Tester.Include(CollectionOperators.ContainsOneOf);
				Tester["ContainsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(CollectionOperators.ContainsNoneOf);

				Assert.IsFalse(Tester.IsValid);
			}
		}
	}
}
