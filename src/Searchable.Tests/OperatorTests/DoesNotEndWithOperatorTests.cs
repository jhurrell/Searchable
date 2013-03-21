using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
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

		[TestClass]
		public class OperatorTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.DoesNotEndWith, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("DoesNotEndWith", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not End With", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not End With", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
