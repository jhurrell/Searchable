using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class LessThanOperatorTests
	{
		protected LessThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new LessThanOperator();
		}

		[TestClass]
		public class OperatorTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.LessThan, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("LessThan", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Less Than", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
