using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsTrueOperatorTests
	{
		protected IsTrueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsTrueOperator();
		}

		[TestClass]
		public class OperatorTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.IsTrue, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is True", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("True", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}			
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsTrueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
