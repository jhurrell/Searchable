using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class ContainsAllOfOperatorTests
	{
		protected ContainsAllOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsAllOfOperator();
		}

		[TestMethod]
		public void ContainsAllOfOperator_Name_IsSet()
		{
			Assert.AreEqual("ContainsAllOf", target.Name);
		}

		[TestMethod]
		public void ContainsAllOfOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Contains All Of", target.DisplayName);
		}

		[TestMethod]
		public void ContainsAllOfOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Contains All Of", target.Symbol);
		}

		[TestMethod]
		public void ContainsAllOfOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void ContainsAllOfOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
		}
	}
}
