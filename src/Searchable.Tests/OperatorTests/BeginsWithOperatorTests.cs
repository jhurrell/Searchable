using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class BeginsWithOperatorTests
	{
		protected BeginsWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new BeginsWithOperator();
		}

		[TestClass]
		public class OperatorTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.BeginsWith, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("BeginsWith", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Begins With", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Begins With", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : BeginsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
