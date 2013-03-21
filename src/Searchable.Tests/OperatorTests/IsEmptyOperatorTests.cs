using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

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
				Assert.AreEqual(Operator.IsEmpty, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("IsEmpty", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Empty", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : IsEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Empty", target.Symbol);
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
