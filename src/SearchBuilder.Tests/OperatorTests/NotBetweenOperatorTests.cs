using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class NotBetweenOperatorTests
	{
		protected NotBetweenOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new NotBetweenOperator();
		}

		[TestMethod]
		public void NotBetweenOperator_Name_IsSet()
		{
			Assert.AreEqual("NotBetween", target.Name);
		}

		[TestMethod]
		public void NotBetweenOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Not Between", target.DisplayName);
		}

		[TestMethod]
		public void NotBetweenOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Not Between", target.Symbol);
		}

		[TestMethod]
		public void NotBetweenOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(2, target.MinValuesRequired);
		}

		[TestMethod]
		public void NotBetweenOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(2, target.MaxValuesRequired);
		}
	}
}
