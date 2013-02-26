using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class DoesNotContainOperatorTests
	{
		protected DoesNotContainOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotContainOperator();
		}

		[TestClass]
		public class OperatorTests : DoesNotContainOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.DoesNotContain, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotContainOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Contain", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : DoesNotContainOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Contain", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotContainOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotContainOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
