using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsFalseOperatorTests
	{
		protected IsFalseOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsFalseOperator();
		}

		[TestMethod]
		public void IsFalseOperator_Name_IsSet()
		{
			Assert.AreEqual("IsFalse", target.Name);
		}

		[TestMethod]
		public void IsFalseOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is False", target.DisplayName);
		}

		[TestMethod]
		public void IsFalseOperator_Symbol_IsSet()
		{
			Assert.AreEqual("False", target.Symbol);
		}

		[TestMethod]
		public void IsFalseOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsFalseOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}
