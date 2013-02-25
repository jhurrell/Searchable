using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class HasValueOperatorTests
	{
		protected HasValueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new HasValueOperator();
		}

		[TestClass]
		public class OperatorTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.HasValue, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Has A Value", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("<> Null", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : HasValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
