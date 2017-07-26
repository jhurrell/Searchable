using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class BeginsWithOperatorTests
	{
		protected BeginsWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new BeginsWithOperator();
		}

		[TestMethod]
		public void BeginsWithOperator_Name_IsSet()
		{
			Assert.AreEqual("BeginsWith", target.Name);
		}

		[TestMethod]
		public void BeginsWithOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Begins With", target.DisplayName);
		}

		[TestMethod]
		public void BeginsWithOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Begins With", target.Symbol);
		}

		[TestMethod]
		public void BeginsWithOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void BeginsWithOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
