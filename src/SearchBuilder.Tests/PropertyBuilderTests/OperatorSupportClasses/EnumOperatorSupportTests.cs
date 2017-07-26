using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SearchBuilder.Operators;
using SearchBuilder.PropertyBuilders;
using SearchBuilder.PropertyBuilders.Enum;

namespace SearchBuilder.Tests.PropertyBuilderTests.OperatorSupportClasses
{
	[TestClass]
	public class EnumOperatorSupportTests
	{
		[TestMethod]
		public void EnumOperatorSupport_GetOperators_ContainsExpectedOperators()
		{
			// Cache a dictionary of operators by the enum.
			var expected = new List<OperatorBase>
			{
				new EqualToOperator(),
				new NotEqualToOperator(),
				new IsOneOfOperator(),
				new IsNotOneOfOperator(),
			};

			var actual = EnumOperatorSupport.GetOperators();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void EnumOperatorSupport_GetOperator_OperatorsDoNotCollide()
		{
			var operatorA = EnumOperatorSupport.GetOperator(EnumOperators.IsOneOf);
			operatorA.Values = new List<object> { "A", "B", "C" };

			var operatorB = EnumOperatorSupport.GetOperator(EnumOperators.IsOneOf);
			operatorB.Values = new List<object> { "X", "Y", "Z" };

			CollectionAssert.AreNotEquivalent(operatorA.Values, operatorB.Values);
		}

		[TestMethod]
		public void EnumOperatorSupport_GetOperator_AllOperatorsHandled()
		{
			var types = Enum.GetValues(typeof(EnumOperators));
			foreach (var type in types)
			{
				var result = EnumOperatorSupport.GetOperator((EnumOperators)type);

				switch ((EnumOperators)type)
				{
					case EnumOperators.EqualTo:
						Assert.IsInstanceOfType(result, typeof(EqualToOperator));
						break;
					case EnumOperators.IsNotOneOf:
						Assert.IsInstanceOfType(result, typeof(IsNotOneOfOperator));
						break;
					case EnumOperators.IsOneOf:
						Assert.IsInstanceOfType(result, typeof(IsOneOfOperator));
						break;
					case EnumOperators.NotEqualTo:
						Assert.IsInstanceOfType(result, typeof(NotEqualToOperator));
						break;
					default:
						Assert.Fail("GetOperator() called with unhandled EnumOperators value.");
						break;
				}
			}
		}
	}
}
