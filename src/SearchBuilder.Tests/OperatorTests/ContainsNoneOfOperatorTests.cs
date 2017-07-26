using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class ContainsNoneOfOperatorTests
	{
		protected ContainsNoneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsNoneOfOperator();
		}

		[TestMethod]
		public void ContainsNoneOfOperator_Name_IsSet()
		{
			Assert.AreEqual("ContainsNoneOf", target.Name);
		}

		[TestMethod]
		public void ContainsNoneOfOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Contains None Of", target.DisplayName);
		}

		[TestMethod]
		public void ContainsNoneOfOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Contains None Of", target.Symbol);
		}

		[TestMethod]
		public void ContainsNoneOfOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void ContainsNoneOfOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
		}
	}
}
