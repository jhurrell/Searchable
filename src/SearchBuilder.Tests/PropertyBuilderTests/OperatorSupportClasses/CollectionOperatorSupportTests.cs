using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using SearchBuilder.PropertyBuilders;
using SearchBuilder.PropertyBuilders.Collection;

namespace SearchBuilder.Tests.PropertyBuilderTests.OperatorSupportClasses
{
	[TestClass]
	public class CollectionOperatorSupportTests
	{
		[TestMethod]
		public void CollectionOperatorSupport_GetOperators_ContainsExpectedOperators()
		{
			// Cache a dictionary of operators by the enum.
			var expected = new List<OperatorBase>
			{
				new ContainsAllOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsOneOfOperator(),
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),
			};

			var actual = CollectionOperatorSupport.GetOperators();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void CollectionOperatorSupport_GetOperator_OperatorsDoNotCollide()
		{
			var operatorA = CollectionOperatorSupport.GetOperator(CollectionOperators.ContainsAllOf);
			operatorA.Values = new List<object> { "A", "B", "C" };

			var operatorB = CollectionOperatorSupport.GetOperator(CollectionOperators.ContainsAllOf);
			operatorB.Values = new List<object> { "X", "Y", "Z" };

			CollectionAssert.AreNotEquivalent(operatorA.Values, operatorB.Values);
		}

		[TestMethod]
		public void CollectionOperatorSupport_GetOperator_AllOperatorsHandled()
		{
			var types = Enum.GetValues(typeof(CollectionOperators));
			foreach (var type in types)
			{
				var result = CollectionOperatorSupport.GetOperator((CollectionOperators)type);

				switch ((CollectionOperators)type)
				{
					case CollectionOperators.ContainsAllOf:
						Assert.IsInstanceOfType(result, typeof(ContainsAllOfOperator));
						break;
					case CollectionOperators.ContainsNoneOf:
						Assert.IsInstanceOfType(result, typeof(ContainsNoneOfOperator));
						break;
					case CollectionOperators.ContainsOneOf:
						Assert.IsInstanceOfType(result, typeof(ContainsOneOfOperator));
						break;
					case CollectionOperators.IsEmpty:
						Assert.IsInstanceOfType(result, typeof(IsEmptyOperator));
						break;
					case CollectionOperators.IsNotEmpty:
						Assert.IsInstanceOfType(result, typeof(IsNotEmptyOperator));
						break;
					default:
						Assert.Fail("GetOperator() called with unhandled CollectionOperators value.");
						break;
				}
			}
		}
	}
}
