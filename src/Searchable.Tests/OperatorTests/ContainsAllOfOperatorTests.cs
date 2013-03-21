using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsAllOfOperatorTests
	{
		protected ContainsAllOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsAllOfOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.ContainsAllOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("ContainsAllOf", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains All Of", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains All Of", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
			}
		}
	}
}
