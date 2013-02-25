using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsOperatorTests
	{
		protected ContainsOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.Contains, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
