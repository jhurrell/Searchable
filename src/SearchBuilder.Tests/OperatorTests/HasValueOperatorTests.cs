using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class HasValueOperatorTests
	{
		protected HasValueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new HasValueOperator();
		}

		[TestMethod]
		public void HasValueOperator_Name_IsSet()
		{
			Assert.AreEqual("HasAValue", target.Name);
		}

		[TestMethod]
		public void HasValueOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Has A Value", target.DisplayName);
		}

		[TestMethod]
		public void HasValueOperator_Symbol_IsSet()
		{
			Assert.AreEqual("<> Null", target.Symbol);
		}

		[TestMethod]
		public void HasValueOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void HasValueOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}
