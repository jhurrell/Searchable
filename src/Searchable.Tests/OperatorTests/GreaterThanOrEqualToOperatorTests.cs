using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class GreaterThanOrEqualToOperatorTests
	{
		protected GreaterThanOrEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new GreaterThanOrEqualToOperator();
		}

		[TestClass]
		public class OperatorTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.GreaterThanOrEqualTo, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("GreaterThanOrEqualTo", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Greater Than Or Equal To", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(">=", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : GreaterThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
