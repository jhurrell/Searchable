using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class EndsWithOperatorTests
	{
		protected EndsWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new EndsWithOperator();
		}

		[TestClass]
		public class OperatorTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.EndsWith, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("EndsWith", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Ends With", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Ends With", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
