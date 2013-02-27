using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class DoesNotHaveValueOperatorTests
	{
		protected DoesNotHaveValueOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotHaveValueOperator();
		}

		[TestClass]
		public class OperatorTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.DoesNotHaveValue, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Have A Value", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("= Null", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotHaveValueOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
