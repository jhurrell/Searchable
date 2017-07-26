using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class DoesNotBeginWithOperatorTests
	{
		protected DoesNotBeginWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotBeginWithOperator();
		}

		[TestMethod]
		public void DoesNotBeginWithOperator_Name_IsSet()
		{
			Assert.AreEqual("DoesNotBeginWith", target.Name);
		}

		[TestMethod]
		public void DoesNotBeginWithOperator_DisplayName_IsSet()
		{
			Assert.AreEqual("Does Not Begin With", target.DisplayName);
		}

		[TestMethod]
		public void DoesNotBeginWithOperator_Symbol_IsSet()
		{
			Assert.AreEqual("Does Not Begin With", target.Symbol);
		}

		[TestMethod]
		public void DoesNotBeginWithOperator_MinValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MinValuesRequired);
		}

		[TestMethod]
		public void DoesNotBeginWithOperator_MaxValuesRequired_IsSet()
		{
			Assert.AreEqual(1, target.MaxValuesRequired);
		}
	}
}
