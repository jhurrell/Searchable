using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class GreaterThanOperatorTests
	{
		protected GreaterThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new GreaterThanOperator();
		}

		[TestMethod]
		public void GreaterThanOperator_Name_IsSet()
		{
			Assert.AreEqual("GreaterThan", target.Name);
		}

		[TestMethod]
		public void GreaterThanOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Greater Than", target.DisplayName);
		}

		[TestMethod]
		public void GreaterThanOperator_Symbol_IsSet()
		{
			Assert.AreEqual(">", target.Symbol);
		}

		[TestMethod]
		public void GreaterThanOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void GreaterThanOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
