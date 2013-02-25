using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

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
				Assert.AreEqual(Operators.LessThanOrEqualTo, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Less Than Or Equal To", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : LessThanOrEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<=", target.Display);
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
