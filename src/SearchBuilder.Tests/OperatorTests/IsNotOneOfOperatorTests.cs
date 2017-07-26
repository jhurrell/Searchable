using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsNotOneOfOperatorTests
	{
		protected IsNotOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsNotOneOfOperator();
		}

		[TestMethod]
		public void IsNotOneOfOperator_Name_IsSet()
		{
			Assert.AreEqual("IsNotOneOf", target.Name);
		}

		[TestMethod]
		public void IsNotOneOfOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is Not One Of", target.DisplayName);
		}

		[TestMethod]
		public void IsNotOneOfOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Is Not One Of", target.Symbol);
		}

		[TestMethod]
		public void IsNotOneOfOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsNotOneOfOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
		}
	}
}