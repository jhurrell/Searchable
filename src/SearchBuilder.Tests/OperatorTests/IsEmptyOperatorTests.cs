using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsEmptyOperatorTests
	{
		protected IsEmptyOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsEmptyOperator();
		}

		[TestMethod]
		public void IsEmptyOperator_Name_IsSet()
		{
			Assert.AreEqual("IsEmpty", target.Name);
		}

		[TestMethod]
		public void IsEmptyOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is Empty", target.DisplayName);
		}

		[TestMethod]
		public void IsEmptyOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Is Empty", target.Symbol);
		}

		[TestMethod]
		public void IsEmptyOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsEmptyOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}
