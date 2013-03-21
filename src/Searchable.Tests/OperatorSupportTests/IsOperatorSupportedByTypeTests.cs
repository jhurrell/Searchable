using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class IsOperatorSupportedByTypeTests
	{
		[TestMethod]
		public void True_For_Valid_Type_Operator_Pairings()
		{
			Assert.IsTrue(OperatorSupport.IsOperatorSupportedByType(typeof(string), Operator.EqualTo));
		}

		[TestMethod]
		public void False_For_Invalid_Type_Operator_Pairings()
		{
			Assert.IsFalse(OperatorSupport.IsOperatorSupportedByType(typeof(string), Operator.ContainsOneOf));
		}

		[TestMethod]
		public void False_For_Unsupported_Type()
		{
			Assert.IsFalse(OperatorSupport.IsOperatorSupportedByType(typeof(IsOperatorSupportedByTypeTests), Operator.EqualTo));
		}
	}
}
