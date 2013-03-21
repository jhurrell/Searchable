using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class HasValueOperatorTests
	{
		protected HasValueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new HasValueOperator();
		}

		[TestClass]
		public class OperatorTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.HasValue, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("HasAValue", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Has A Value", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<> Null", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
