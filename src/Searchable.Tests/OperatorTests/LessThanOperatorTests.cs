using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class LessThanOperatorTests
	{
		protected LessThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new LessThanOperator();
		}

		[TestClass]
		public class OperatorTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.LessThan, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Less Than", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : LessThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
