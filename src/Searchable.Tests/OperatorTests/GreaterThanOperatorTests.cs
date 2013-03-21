using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class GreaterThanOperatorTests
	{
		protected GreaterThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new GreaterThanOperator();
		}

		[TestClass]
		public class OperatorTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.GreaterThan, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("GreaterThan", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Greater Than", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(">", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
