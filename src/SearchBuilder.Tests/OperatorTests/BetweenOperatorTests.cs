using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class BetweenOperatorTests
	{
		protected BetweenOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new BetweenOperator();
		}

		[TestMethod]
		public void BetweenOperator_Name_IsSet()
		{
			Assert.AreEqual("Between", target.Name);
		}

		[TestMethod]
		public void BetweenOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Between", target.DisplayName);
		}

		[TestMethod]
		public void BetweenOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Between", target.Symbol);
		}

		[TestMethod]
		public void BetweenOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(2, target.MinValuesRequired);
		}

		[TestMethod]
		public void BetweenOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(2, target.MaxValuesRequired);
		}
	}
}
