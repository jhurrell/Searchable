using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class LessThanOrEqualToOperatorTests
	{
		protected LessThanOrEqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new LessThanOrEqualToOperator();
		}

		[TestClass]
		public class OperatorTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.LessThanOrEqualTo, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("LessThanOrEqualTo", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Less Than Or Equal To", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<=", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
