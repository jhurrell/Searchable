using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class EqualToOperatorTests
	{
		protected EqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new EqualToOperator();
		}

		[TestMethod]
		public void EqualToOperator_Name_IsSet()
		{
			Assert.AreEqual("EqualTo", target.Name);
		}

		[TestMethod]
		public void EqualToOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Equal To", target.DisplayName);
		}

		[TestMethod]
		public void EqualToOperator_Symbol_IsSet()
		{
			Assert.AreEqual("=", target.Symbol);
		}

		[TestMethod]
		public void EqualToOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void EqualToOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
