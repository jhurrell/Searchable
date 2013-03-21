using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
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

		[TestClass]
		public class OperatorTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.DoesNotHaveValue, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("DoesNotHaveAValue", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Have A Value", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("= Null", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
