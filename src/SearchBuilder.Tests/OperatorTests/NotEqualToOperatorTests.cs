using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class NotEqualToOperatorTests
	{
		protected NotEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new NotEqualToOperator();
		}

		[TestMethod]
		public void NotEqualToOperator_Name_IsSet()
		{
			Assert.AreEqual("NotEqualTo", target.Name);
		}

		[TestMethod]
		public void NotEqualToOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Not Equal To", target.DisplayName);
		}

		[TestMethod]
		public void NotEqualToOperator_Symbol_IsSet()
		{
			Assert.AreEqual("<>", target.Symbol);
		}

		[TestMethod]
		public void NotEqualToOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void NotEqualToOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
