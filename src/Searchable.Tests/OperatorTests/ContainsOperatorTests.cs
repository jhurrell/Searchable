using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsOperatorTests
	{
		protected ContainsOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.Contains, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
