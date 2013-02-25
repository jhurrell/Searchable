using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsAllOfOperatorTests
	{
		protected ContainsAllOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsAllOfOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.ContainsAllOf, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains All Of", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains All Of", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsAllOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
			}
		}
	}
}
