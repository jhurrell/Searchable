using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class LessThanOperatorTests
	{
		protected LessThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new LessThanOperator();
		}

		[TestMethod]
		public void LessThanOperator_Name_IsSet()
		{
			Assert.AreEqual("LessThan", target.Name);
		}

		[TestMethod]
		public void LessThanOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Less Than", target.DisplayName);
		}

		[TestMethod]
		public void LessThanOperator_Symbol_IsSet()
		{
			Assert.AreEqual("<", target.Symbol);
		}

		[TestMethod]
		public void LessThanOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void LessThanOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
