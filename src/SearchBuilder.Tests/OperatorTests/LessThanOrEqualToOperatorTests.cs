using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class LessThanOrEqualToOperatorTests
	{
		protected LessThanOrEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new LessThanOrEqualToOperator();
		}

		[TestMethod]
		public void LessThanOrEqualToOperator_Name_IsSet()
		{
			Assert.AreEqual("LessThanOrEqualTo", target.Name);
		}

		[TestMethod]
		public void LessThanOrEqualToOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Less Than Or Equal To", target.DisplayName);
		}

		[TestMethod]
		public void LessThanOrEqualToOperator_Symbol_IsSet()
		{
			Assert.AreEqual("<=", target.Symbol);
		}

		[TestMethod]
		public void LessThanOrEqualToOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void LessThanOrEqualToOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
