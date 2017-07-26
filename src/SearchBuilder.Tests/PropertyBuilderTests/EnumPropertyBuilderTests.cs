using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchBuilder.PropertyBuilders.Enum;

namespace SearchBuilder.Tests.PropertyBuilderTests
{
	[TestClass]
	public class EnumPropertyBuilderTests
	{
		protected EnumPropertyBuilder Tester;

		[TestInitialize]
		public void TestInitialize()
		{
			Tester = new SearchBuilder<SampleClass>().CanSearch(s => s.EnumProperty) as EnumPropertyBuilder;
		}

		[TestClass]
		public class IncludeTests : EnumPropertyBuilderTests
		{
			[TestMethod]
			public void Include_ReturnType_IsEnumPropertyBuilder()
			{
				var result = Tester.Include(EnumOperators.EqualTo);
				Assert.IsInstanceOfType(result, typeof(EnumPropertyBuilder));
			}

			[TestMethod]
			public void Include_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Include(EnumOperators.EqualTo);
					Tester.Include(EnumOperators.EqualTo);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'EqualTo'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_CallingTwiceWithChainingForSameOprtator_RaisesException()
			{
				try
				{
					Tester
						.Include(EnumOperators.EqualTo)
						.Include(EnumOperators.EqualTo);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'EqualTo'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_AndExclude_RaisesException()
			{
				try
				{
					Tester.Include(EnumOperators.EqualTo);
					Tester.Exclude(EnumOperators.EqualTo);
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
				Tester.Include(EnumOperators.EqualTo);
				var countAfter = Tester.Operators.Count;

				Assert.AreEqual(EnumOperatorSupport.GetOperators().Count, countBefore);
				Assert.AreEqual(1, countAfter);
			}

			[TestMethod]
			public void Include_ForProperties_IncludesOnlyThosePropertiesInPropertiesCollection()
			{
				string[] expected = { "EqualTo", "IsNotOneOf", "IsOneOf", "NotEqualTo" };
				Tester
					.Include(EnumOperators.EqualTo)
					.Include(EnumOperators.IsNotOneOf)
					.Include(EnumOperators.IsOneOf)
					.Include(EnumOperators.NotEqualTo);

				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.AreEqual(expected, actual);
			}
		}

		[TestClass]
		public class ExcludeTests : EnumPropertyBuilderTests
		{
			[TestMethod]
			public void Exclude_ReturnType_IsEnumPropertyBuilder()
			{
				var result = Tester.Exclude(EnumOperators.EqualTo);
				Assert.IsInstanceOfType(result, typeof(EnumPropertyBuilder));
			}

			[TestMethod]
			public void Exclude_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Exclude(EnumOperators.EqualTo);
					Tester.Exclude(EnumOperators.EqualTo);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'EqualTo'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_CallingTwiceWithChainingForSameOperator_RaisesException()
			{
				try
				{
					Tester
						.Exclude(EnumOperators.EqualTo)
						.Exclude(EnumOperators.EqualTo);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'EqualTo'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_AndInclude_RaisesException()
			{
				try
				{
					Tester.Exclude(EnumOperators.EqualTo);
					Tester.Include(EnumOperators.EqualTo);
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
				Tester.Exclude(EnumOperators.EqualTo);
				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.DoesNotContain(actual, "EqualTo");
			}
		}

		[TestClass]
		public class IsValidTests : EnumPropertyBuilderTests
		{
			[TestMethod]
			public void IsValid_WhenSingleOperatorAndNotIsValid_IsFalse()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.EnumProperty) as EnumPropertyBuilder;
				Tester.Include(EnumOperators.IsOneOf);

				Assert.IsFalse(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenSingleOperatorAndIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.EnumProperty) as EnumPropertyBuilder;
				Tester.Include(EnumOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndAllIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.EnumProperty) as EnumPropertyBuilder;
				Tester.Include(EnumOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(EnumOperators.IsNotOneOf);
				Tester["IsNotOneOf"].Values = new List<object> { "X", "Y", "Z" };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndOneNotIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.EnumProperty) as EnumPropertyBuilder;
				Tester.Include(EnumOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { "A", "B", "C" };
				Tester.Include(EnumOperators.IsNotOneOf);

				Assert.IsFalse(Tester.IsValid);
			}
		}
	}
}
