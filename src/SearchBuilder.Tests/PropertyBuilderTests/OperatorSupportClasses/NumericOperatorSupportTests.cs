using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using SearchBuilder.PropertyBuilders;
using SearchBuilder.PropertyBuilders.Numeric;

namespace SearchBuilder.Tests.PropertyBuilderTests.OperatorSupportClasses
{
	[TestClass]
	public class NumericOperatorSupportTests
	{
		[TestMethod]
		public void NumericOperatorSupport_Operators_ContainsExpectedOperators()
		{
			// Cache a dictionary of operators by the enum.
			var expected = new List<OperatorBase>
			{
				new BetweenOperator(),
				new DoesNotHaveValueOperator(),
				new EqualToOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
				new NotBetweenOperator(),
				new NotEqualToOperator(),
			};

			var actual = NumericOperatorSupport.GetOperators();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void NumericOperatorSupport_GetOperator_OperatorsDoNotCollide()
		{
			var operatorA = NumericOperatorSupport.GetOperator(NumericOperators.Between);
			operatorA.Values = new List<object> { "A", "B" };

			var operatorB = NumericOperatorSupport.GetOperator(NumericOperators.Between);
			operatorB.Values = new List<object> { "X", "Y" };

			CollectionAssert.AreNotEquivalent(operatorA.Values, operatorB.Values);
		}

		[TestMethod]
		public void NumericOperatorSupport_GetOperator_AllOperatorsHandled()
		{
			var types = Enum.GetValues(typeof(NumericOperators));
			foreach (var type in types)
			{
				var result = NumericOperatorSupport.GetOperator((NumericOperators)type);

				switch ((NumericOperators)type)
				{
					case NumericOperators.EqualTo:
						Assert.IsInstanceOfType(result, typeof(EqualToOperator));
						break;
					case NumericOperators.NotEqualTo:
						Assert.IsInstanceOfType(result, typeof(NotEqualToOperator));
						break;
					case NumericOperators.Between:
						Assert.IsInstanceOfType(result, typeof(BetweenOperator));
						break;
					case NumericOperators.NotBetween:
						Assert.IsInstanceOfType(result, typeof(NotBetweenOperator));
						break;
					case NumericOperators.IsOneOf:
						Assert.IsInstanceOfType(result, typeof(IsOneOfOperator));
						break;
					case NumericOperators.IsNotOneOf:
						Assert.IsInstanceOfType(result, typeof(IsNotOneOfOperator));
						break;
					case NumericOperators.HasValue:
						Assert.IsInstanceOfType(result, typeof(HasValueOperator));
						break;
					case NumericOperators.DoesNotHaveValue:
						Assert.IsInstanceOfType(result, typeof(DoesNotHaveValueOperator));
						break;
					case NumericOperators.GreaterThan:
						Assert.IsInstanceOfType(result, typeof(GreaterThanOperator));
						break;
					case NumericOperators.GreaterThanOrEqualTo:
						Assert.IsInstanceOfType(result, typeof(GreaterThanOrEqualToOperator));
						break;
					case NumericOperators.LessThan:
						Assert.IsInstanceOfType(result, typeof(LessThanOperator));
						break;
					case NumericOperators.LessThanOrEqualTo:
						Assert.IsInstanceOfType(result, typeof(LessThanOrEqualToOperator));
						break;
					default:
						Assert.Fail("GetOperator() called with unhandled NumericOperators value.");
						break;
				}
			}
		}
	}
}
