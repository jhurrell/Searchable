using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class DoesNotEndWithOperatorTests
	{
		protected DoesNotEndWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotEndWithOperator();
		}

		[TestMethod]
		public void DoesNotEndWithOperator_Name_IsSet()
		{
			Assert.AreEqual("DoesNotEndWith", target.Name);
		}

		[TestMethod]
		public void DoesNotEndWithOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Does Not End With", target.DisplayName);
		}

		[TestMethod]
		public void DoesNotEndWithOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Does Not End With", target.Symbol);
		}

		[TestMethod]
		public void DoesNotEndWithOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void DoesNotEndWithOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
