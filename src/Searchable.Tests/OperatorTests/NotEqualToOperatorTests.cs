using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

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
				Assert.AreEqual(Operators.NotEqualTo, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Not Equal To", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : NotEqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<>", target.Display);
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
