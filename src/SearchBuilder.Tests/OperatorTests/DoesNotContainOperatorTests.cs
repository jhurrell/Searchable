using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class DoesNotContainOperatorTests
	{
		protected DoesNotContainOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotContainOperator();
		}

		[TestMethod]
		public void DoesNotContainOperator_Name_IsSet()
		{
			Assert.AreEqual("DoesNotContain", target.Name);
		}

		[TestMethod]
		public void DoesNotContainOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Does Not Contain", target.DisplayName);
		}

		[TestMethod]
		public void DoesNotContainOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Does Not Contain", target.Symbol);
		}

		[TestMethod]
		public void DoesNotContainOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void DoesNotContainOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
