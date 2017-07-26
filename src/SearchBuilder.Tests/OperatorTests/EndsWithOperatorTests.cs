using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class EndsWithOperatorTests
	{
		protected EndsWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new EndsWithOperator();
		}

		[TestMethod]
		public void EndsWithOperator_Name_IsSet()
		{
			Assert.AreEqual("EndsWith", target.Name);
		}

		[TestMethod]
		public void EndsWithOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Ends With", target.DisplayName);
		}

		[TestMethod]
		public void EndsWithOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Ends With", target.Symbol);
		}

		[TestMethod]
		public void EndsWithOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void EndsWithOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
