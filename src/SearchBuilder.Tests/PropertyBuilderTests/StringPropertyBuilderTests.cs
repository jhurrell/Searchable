using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchBuilder.PropertyBuilders.String;

namespace SearchBuilder.Tests.PropertyBuilderTests
{
	[TestClass]
	public class StringPropertyBuilderTests
	{
		protected StringPropertyBuilder Tester;

		[TestInitialize]
		public void TestInitialize()
		{
			Tester = new SearchBuilder<SampleClass>().CanSearch(s => s.StringProperty) as StringPropertyBuilder;
		}

		[TestClass]
		public class IncludeTests : StringPropertyBuilderTests
		{
			[TestMethod]
			public void Include_ReturnType_IsStringPropertyBuilder()
			{
				var result = Tester.Include(StringOperators.BeginsWith);
				Assert.IsInstanceOfType(result, typeof(StringPropertyBuilder));
			}

			[TestMethod]
			public void Include_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Include(StringOperators.BeginsWith);
					Tester.Include(StringOperators.BeginsWith);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'BeginsWith'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_CallingTwiceWithChainingForSameOprtator_RaisesException()
			{
				try
				{
					Tester
						.Include(StringOperators.BeginsWith)
						.Include(StringOperators.BeginsWith);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'BeginsWith'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_AndExclude_RaisesException()
			{
				try
				{
					Tester.Include(StringOperators.BeginsWith);
					Tester.Exclude(StringOperators.BeginsWith);
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
				Tester.Include(StringOperators.BeginsWith);
				var countAfter = Tester.Operators.Count;

				Assert.AreEqual(StringOperatorSupport.GetOperators().Count, countBefore);
				Assert.AreEqual(1, countAfter);
			}

			[TestMethod]
			public void Include_ForProperties_IncludesOnlyThosePropertiesInPropertiesCollection()
			{
				string[] expected = { "BeginsWith", "EndsWith", "EqualTo" };
				Tester
					.Include(StringOperators.BeginsWith)
					.Include(StringOperators.EndsWith)
					.Include(StringOperators.EqualTo);

				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.AreEqual(expected, actual);
			}
		}

		[TestClass]
		public class ExcludeTests : StringPropertyBuilderTests
		{
			[TestMethod]
			public void Exclude_ReturnType_IsStringPropertyBuilder()
			{
				var result = Tester.Exclude(StringOperators.BeginsWith);
				Assert.IsInstanceOfType(result, typeof(StringPropertyBuilder));
			}

			[TestMethod]
			public void Exclude_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Exclude(StringOperators.BeginsWith);
					Tester.Exclude(StringOperators.BeginsWith);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'BeginsWith'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_CallingTwiceWithChainingForSameOperator_RaisesException()
			{
				try
				{
					Tester
						.Exclude(StringOperators.BeginsWith)
						.Exclude(StringOperators.BeginsWith);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'BeginsWith'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_AndInclude_RaisesException()
			{
				try
				{
					Tester.Exclude(StringOperators.BeginsWith);
					Tester.Include(StringOperators.BeginsWith);
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
				Tester.Exclude(StringOperators.BeginsWith);
				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.DoesNotContain(actual, "BeginsWith");
			}
		}

		[TestClass]
		public class IsValidTests : StringPropertyBuilderTests
		{
			[TestMethod]
			public void IsValid_WhenSingleOperatorAndNotIsValid_IsFalse()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.StringProperty) as StringPropertyBuilder;
				Tester.Include(StringOperators.IsOneOf);

				Assert.IsFalse(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenSingleOperatorAndIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.StringProperty) as StringPropertyBuilder;
				Tester.Include(StringOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndAllIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.StringProperty) as StringPropertyBuilder;
				Tester.Include(StringOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(StringOperators.IsNotOneOf);
				Tester["IsNotOneOf"].Values = new List<object> { "X", "Y", "Z" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndOneNotIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.StringProperty) as StringPropertyBuilder;
				Tester.Include(StringOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(StringOperators.IsNotOneOf);

				Assert.IsFalse(Tester.IsValid);
			}
		}
	}
}
