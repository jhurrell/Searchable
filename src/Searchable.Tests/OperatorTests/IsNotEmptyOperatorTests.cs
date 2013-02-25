using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsNotEmptyOperatorTests
	{
		protected IsNotEmptyOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsNotEmptyOperator();
		}

		[TestClass]
		public class OperatorTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.IsNotEmpty, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not Empty", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not Empty", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}