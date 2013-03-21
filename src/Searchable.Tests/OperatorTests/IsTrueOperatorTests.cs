using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsTrueOperatorTests
	{
		protected IsTrueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsTrueOperator();
		}

		[TestClass]
		public class OperatorTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.IsTrue, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("IsTrue", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is True", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("True", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}			
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
