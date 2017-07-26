using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsTrueOperatorTests
	{
		protected IsTrueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsTrueOperator();
		}

		[TestMethod]
		public void IsTrueOperator_Name_IsSet()
		{
			Assert.AreEqual("IsTrue", target.Name);
		}

		[TestMethod]
		public void IsTrueOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is True", target.DisplayName);
		}

		[TestMethod]
		public void IsTrueOperator_Symbol_IsSet()
		{
			Assert.AreEqual("True", target.Symbol);
		}

		[TestMethod]
		public void IsTrueOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsTrueOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}
