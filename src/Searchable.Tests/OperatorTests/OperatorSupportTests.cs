using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Linq;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class OperatorSupportTests
	{
		[TestClass]
		public class OperatorsTests : OperatorSupportTests
		{
			[TestMethod]
			public void Collection_Not_Empty()
			{
				Assert.IsNotNull(OperatorSupport.Operators);
			}

			[TestMethod]
			public void Collection_Contains_Each_Operator()
			{
				foreach (var op in Enum.GetValues(typeof(Operator)).Cast<Operator>())
				{
					Assert.AreEqual(op, OperatorSupport.Operators[op].OperatorType);
				}				
			}
		}
	}
}
