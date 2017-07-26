using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsNotEmptyOperatorTests
	{
		protected IsNotEmptyOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsNotEmptyOperator();
		}

		[TestMethod]
		public void IsNotEmptyOperator_Name_IsSet()
		{
			Assert.AreEqual("IsNotEmpty", target.Name);
		}

		[TestMethod]
		public void IsNotEmptyOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is Not Empty", target.DisplayName);
		}

		[TestMethod]
		public void IsNotEmptyOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Is Not Empty", target.Symbol);
		}

		[TestMethod]
		public void IsNotEmptyOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsNotEmptyOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}