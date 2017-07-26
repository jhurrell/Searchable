using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchBuilder.PropertyBuilders.Numeric;

namespace SearchBuilder.Tests.PropertyBuilderTests
{
	[TestClass]
	public class NumericPropertyBuilderTests
	{
		protected NumericPropertyBuilder Tester;

		[TestInitialize]
		public void TestInitialize()
		{
			Tester = new SearchBuilder<SampleClass>().CanSearch(s => s.IntProperty) as NumericPropertyBuilder;
		}

		[TestClass]
		public class IncludeTests : NumericPropertyBuilderTests
		{
			[TestMethod]
			public void Include_ReturnType_IsNumericPropertyBuilder()
			{
				var result = Tester.Include(NumericOperators.GreaterThan);
				Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
			}

			[TestMethod]
			public void Include_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Include(NumericOperators.GreaterThan);
					Tester.Include(NumericOperators.GreaterThan);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'GreaterThan'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_CallingTwiceWithChainingForSameOprtator_RaisesException()
			{
				try
				{
					Tester
						.Include(NumericOperators.GreaterThan)
						.Include(NumericOperators.GreaterThan);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Include() has already been called for operator 'GreaterThan'.", ex.Message);
				}
			}

			[TestMethod]
			public void Include_AndExclude_RaisesException()
			{
				try
				{
					Tester.Include(NumericOperators.GreaterThan);
					Tester.Exclude(NumericOperators.GreaterThan);
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
				Tester.Include(NumericOperators.GreaterThan);
				var countAfter = Tester.Operators.Count;

				Assert.AreEqual(NumericOperatorSupport.GetOperators().Count, countBefore);
				Assert.AreEqual(1, countAfter);
			}

			[TestMethod]
			public void Include_ForProperties_IncludesOnlyThosePropertiesInPropertiesCollection()
			{
				string[] expected = { "EqualTo", "GreaterThan", "LessThan" };
				Tester
					.Include(NumericOperators.GreaterThan)
					.Include(NumericOperators.LessThan)
					.Include(NumericOperators.EqualTo);

				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.AreEqual(expected, actual);
			}
		}

		[TestClass]
		public class ExcludeTests : NumericPropertyBuilderTests
		{
			[TestMethod]
			public void Exclude_ReturnType_IsNumericPropertyBuilder()
			{
				var result = Tester.Exclude(NumericOperators.GreaterThan);
				Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
			}

			[TestMethod]
			public void Exclude_CallingTwiceForSameOprtator_RaisesException()
			{
				try
				{
					Tester.Exclude(NumericOperators.GreaterThan);
					Tester.Exclude(NumericOperators.GreaterThan);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'GreaterThan'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_CallingTwiceWithChainingForSameOperator_RaisesException()
			{
				try
				{
					Tester
						.Exclude(NumericOperators.GreaterThan)
						.Exclude(NumericOperators.GreaterThan);
					Assert.Fail();
				}
				catch (Exception ex)
				{
					Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
					Assert.AreEqual("Exclude() has already been called for operator 'GreaterThan'.", ex.Message);
				}
			}

			[TestMethod]
			public void Exclude_AndInclude_RaisesException()
			{
				try
				{
					Tester.Exclude(NumericOperators.GreaterThan);
					Tester.Include(NumericOperators.GreaterThan);
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
				Tester.Exclude(NumericOperators.GreaterThan);
				var actual = Tester.Operators.Select(p => p.Name).OrderBy(p => p).ToArray();

				CollectionAssert.DoesNotContain(actual, "GreaterThan");
			}
		}

		[TestClass]
		public class IsValidTests : NumericPropertyBuilderTests
		{
			[TestMethod]
			public void IsValid_WhenSingleOperatorAndNotIsValid_IsFalse()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.IntProperty) as NumericPropertyBuilder;
				Tester.Include(NumericOperators.IsOneOf);

				Assert.IsFalse(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenSingleOperatorAndIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.IntProperty) as NumericPropertyBuilder;
				Tester.Include(NumericOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { 1, 2, 3 };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndAllIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.IntProperty) as NumericPropertyBuilder;
				Tester.Include(NumericOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { 1, 2, 3 };
				Tester.Include(NumericOperators.IsNotOneOf);
				Tester["IsNotOneOf"].Values = new List<object> { 9, 8, 7 };

				Assert.IsTrue(Tester.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenMultipleOperatorsAndOneNotIsValid_IsTrue()
			{
				Tester = new SearchBuilder<SampleClass>().CanSearch(x => x.IntProperty) as NumericPropertyBuilder;
				Tester.Include(NumericOperators.IsOneOf);
				Tester["IsOneOf"].Values = new List<object> { 1, 2, 3 };
				Tester.Include(NumericOperators.IsNotOneOf);

				Assert.IsFalse(Tester.IsValid);
			}
		}
	}
}
