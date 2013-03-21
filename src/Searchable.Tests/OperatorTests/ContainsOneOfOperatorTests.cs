using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsOneOfOperatorTests
	{
		protected ContainsOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsOneOfOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.ContainsOneOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("ContainsOneOf", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains One Of", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains One Of", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
			}
		}
	}
}
