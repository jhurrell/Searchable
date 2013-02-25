using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsFalseOperatorTests
	{
		protected IsFalseOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsFalseOperator();
		}

		[TestClass]
		public class OperatorTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.IsFalse, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is False", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("False", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
