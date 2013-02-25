using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsEmptyOperatorTests
	{
		protected IsEmptyOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsEmptyOperator();
		}

		[TestClass]
		public class OperatorTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.IsEmpty, target.Operator);
			}
		}

		[TestClass]
		public class NameTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Empty", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Empty", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
