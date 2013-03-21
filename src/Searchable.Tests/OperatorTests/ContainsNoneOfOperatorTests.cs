using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsNoneOfOperatorTests
	{
		protected ContainsNoneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsNoneOfOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.ContainsNoneOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("ContainsNoneOf", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains None Of", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains None Of", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
			}
		}
	}
}
