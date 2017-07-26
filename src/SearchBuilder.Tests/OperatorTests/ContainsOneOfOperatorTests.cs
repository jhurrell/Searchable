using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class ContainsOneOfOperatorTests
	{
		protected ContainsOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsOneOfOperator();
		}

		[TestMethod]
		public void ContainsOneOfOperator_Name_IsSet()
		{
			Assert.AreEqual("ContainsOneOf", target.Name);
		}

		[TestMethod]
		public void ContainsOneOfOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Contains One Of", target.DisplayName);
		}

		[TestMethod]
		public void ContainsOneOfOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Contains One Of", target.Symbol);
		}

		[TestMethod]
		public void ContainsOneOfOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void ContainsOneOfOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
		}
	}
}
