using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class DoesNotBeginWithOperatorTests
	{
		protected DoesNotBeginWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotBeginWithOperator();
		}

		[TestClass]
		public class OperatorTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.DoesNotBeginWith, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("DoesNotBeginWith", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Begin With", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Begin With", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
