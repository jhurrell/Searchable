using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class EqualToOperatorTests
	{
		protected EqualToOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new EqualToOperator();
		}

		[TestClass]
		public class OperatorTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.EqualTo, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Equal To", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("=", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}
