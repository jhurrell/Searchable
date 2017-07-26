using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsOneOfOperatorTests
	{
		protected IsOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsOneOfOperator();
		}

		[TestMethod]
		public void IsOneOfOperator_Name_IsSet()
		{
			Assert.AreEqual("IsOneOf", target.Name);
		}

		[TestMethod]
		public void IsOneOfOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Is One Of", target.DisplayName);
		}

		[TestMethod]
		public void IsOneOfOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Is One Of", target.Symbol);
		}

		[TestMethod]
		public void IsOneOfOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void IsOneOfOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
		}
	}
}