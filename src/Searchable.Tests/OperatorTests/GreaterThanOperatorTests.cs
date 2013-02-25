using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class GreaterThanOperatorTests
	{
		protected GreaterThanOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new GreaterThanOperator();
		}

		[TestClass]
		public class OperatorTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.GreaterThan, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Greater Than", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(">", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : GreaterThanOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
