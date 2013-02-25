using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class ContainsNoneOfOperatorTests
	{
		protected ContainsNoneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new ContainsNoneOfOperator();
		}

		[TestClass]
		public class OperatorTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.ContainsNoneOf, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains None Of", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Contains None Of", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : ContainsNoneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(int.MaxValue, target.MaxValuesRequired);
			}
		}
	}
}
