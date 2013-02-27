using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class DoesNotBeginWithOperatorTests
	{
		protected DoesNotBeginWithOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new DoesNotBeginWithOperator();
		}

		[TestClass]
		public class OperatorTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.DoesNotBeginWith, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Begin With", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Does Not Begin With", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : DoesNotBeginWithOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
