using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class NotEqualToOperatorTests
	{
		protected NotEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new NotEqualToOperator();
		}

		[TestClass]
		public class OperatorTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.NotEqualTo, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("NotEqualTo", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Not Equal To", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<>", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
