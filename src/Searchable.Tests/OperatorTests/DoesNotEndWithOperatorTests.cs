using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class DoesNotEndWithOperatorTests
	{
		protected DoesNotEndWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotEndWithOperator();
		}

		[TestClass]
		public class OperatorTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.DoesNotEndWith, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not End With", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not End With", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotEndWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
