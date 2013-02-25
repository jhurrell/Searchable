using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class EndsWithOperatorTests
	{
		protected EndsWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new EndsWithOperator();
		}

		[TestClass]
		public class OperatorTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.EndsWith, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Ends With", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Ends With", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : EndsWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
