using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class GreaterThanOrEqualToOperatorTests
	{
		protected GreaterThanOrEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new GreaterThanOrEqualToOperator();
		}

		[TestMethod]
		public void GreaterThanOrEqualToOperator_Name_IsSet()
		{
			Assert.AreEqual("GreaterThanOrEqualTo", target.Name);
		}

		[TestMethod]
		public void GreaterThanOrEqualToOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Greater Than Or Equal To", target.DisplayName);
		}

		[TestMethod]
		public void GreaterThanOrEqualToOperator_Symbol_IsSet()
		{
			Assert.AreEqual(">=", target.Symbol);
		}

		[TestMethod]
		public void GreaterThanOrEqualToOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void GreaterThanOrEqualToOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
