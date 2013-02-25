using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class BetweenOperatorTests
	{
		protected BetweenOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new BetweenOperator();
		}

		[TestClass]
		public class OperatorTests : BetweenOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.Between, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : BetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Between", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : BetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Between", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : BetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(2, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : BetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(2, target.MaxValuesRequired);
			}
		}
	}
}
