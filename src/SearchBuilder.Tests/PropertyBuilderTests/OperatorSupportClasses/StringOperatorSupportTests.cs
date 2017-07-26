using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using SearchBuilder.PropertyBuilders;
using SearchBuilder.PropertyBuilders.String;

namespace SearchBuilder.Tests.PropertyBuilderTests.OperatorSupportClasses
{
	[TestClass]
	public class StringOperatorSupportTests
	{
		[TestMethod]
		public void StringOperatorSupport_Operators_ContainsExpectedOperators()
		{
			// Cache a dictionary of operators by the enum.
			var expected = new List<OperatorBase>
			{
				new BeginsWithOperator(),
				new BetweenOperator(),
				new ContainsOperator(),
				new DoesNotBeginWithOperator(),
				new DoesNotContainOperator(),
				new DoesNotEndWithOperator(),
				new DoesNotHaveValueOperator(),
				new EndsWithOperator(),
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

			var actual = StringOperatorSupport.GetOperators();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void StringOperatorSupport_GetOperator_OperatorsDoNotCollide()
		{
			var operatorA = StringOperatorSupport.GetOperator(StringOperators.BeginsWith);
			operatorA.Values = new List<object> { "A" };

			var operatorB = StringOperatorSupport.GetOperator(StringOperators.BeginsWith);
			operatorB.Values = new List<object> { "X" };

			CollectionAssert.AreNotEquivalent(operatorA.Values, operatorB.Values);
		}

		[TestMethod]
		public void StringOperatorSupport_GetOperator_AllOperatorsHandled()
		{
			var types = Enum.GetValues(typeof(StringOperators));
			foreach (var type in types)
			{
				var result = StringOperatorSupport.GetOperator((StringOperators)type);

				switch ((StringOperators)type)
				{
					case StringOperators.BeginsWith:
						Assert.IsInstanceOfType(result, typeof(BeginsWithOperator));
						break;
					case StringOperators.Between:
						Assert.IsInstanceOfType(result, typeof(BetweenOperator));
						break;
					case StringOperators.Contains:
						Assert.IsInstanceOfType(result, typeof(ContainsOperator));
						break;
					case StringOperators.DoesNotBeginWith:
						Assert.IsInstanceOfType(result, typeof(DoesNotBeginWithOperator));
						break;
					case StringOperators.DoesNotContain:
						Assert.IsInstanceOfType(result, typeof(DoesNotContainOperator));
						break;
					case StringOperators.DoesNotEndWith:
						Assert.IsInstanceOfType(result, typeof(DoesNotEndWithOperator));
						break;
					case StringOperators.DoesNotHaveValue:
						Assert.IsInstanceOfType(result, typeof(DoesNotHaveValueOperator));
						break;
					case StringOperators.EndsWith:
						Assert.IsInstanceOfType(result, typeof(EndsWithOperator));
						break;
					case StringOperators.EqualTo:
						Assert.IsInstanceOfType(result, typeof(EqualToOperator));
						break;
					case StringOperators.GreaterThan:
						Assert.IsInstanceOfType(result, typeof(GreaterThanOperator));
						break;
					case StringOperators.GreaterThanOrEqualTo:
						Assert.IsInstanceOfType(result, typeof(GreaterThanOrEqualToOperator));
						break;
					case StringOperators.HasValue:
						Assert.IsInstanceOfType(result, typeof(HasValueOperator));
						break;
					case StringOperators.IsNotOneOf:
						Assert.IsInstanceOfType(result, typeof(IsNotOneOfOperator));
						break;
					case StringOperators.IsOneOf:
						Assert.IsInstanceOfType(result, typeof(IsOneOfOperator));
						break;
					case StringOperators.LessThan:
						Assert.IsInstanceOfType(result, typeof(LessThanOperator));
						break;
					case StringOperators.LessThanOrEqualTo:
						Assert.IsInstanceOfType(result, typeof(LessThanOrEqualToOperator));
						break;
					case StringOperators.NotBetween:
						Assert.IsInstanceOfType(result, typeof(NotBetweenOperator));
						break;
					case StringOperators.NotEqualTo:
						Assert.IsInstanceOfType(result, typeof(NotEqualToOperator));
						break;
					default:
						Assert.Fail("GetOperator() called with unhandled StringOperators value.");
						break;
				}
			}
		}
	}
}
