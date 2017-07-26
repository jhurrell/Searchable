using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class ContainsOperatorTests
	{
		protected ContainsOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsOperator();
		}

		[TestMethod]
		public void ContainsOperator_Name_IsSet()
		{
			Assert.AreEqual("Contains", target.Name);
		}

		[TestMethod]
		public void ContainsOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Contains", target.DisplayName);
		}

		[TestMethod]
		public void ContainsOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Contains", target.Symbol);
		}

		[TestMethod]
		public void ContainsOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void ContainsOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
