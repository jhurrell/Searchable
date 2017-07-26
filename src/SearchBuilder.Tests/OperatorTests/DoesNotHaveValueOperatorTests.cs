using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class DoesNotHaveValueOperatorTests
	{
		protected DoesNotHaveValueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotHaveValueOperator();
		}

		[TestMethod]
		public void DoesNotHaveValueOperator_Name_IsSet()
		{
			Assert.AreEqual("DoesNotHaveAValue", target.Name);
		}

		[TestMethod]
		public void DoesNotHaveValueOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Does Not Have A Value", target.DisplayName);
		}

		[TestMethod]
		public void DoesNotHaveValueOperator_Symbol_IsSet()
		{
			Assert.AreEqual("= Null", target.Symbol);
		}

		[TestMethod]
		public void DoesNotHaveValueOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MinValuesRequired);
		}

		[TestMethod]
		public void DoesNotHaveValueOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(0, target.MaxValuesRequired);
		}
	}
}
