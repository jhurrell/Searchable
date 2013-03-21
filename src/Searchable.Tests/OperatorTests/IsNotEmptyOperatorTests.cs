using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

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
				Assert.AreEqual(Operator.IsNotEmpty, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("IsNotEmpty", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not Empty", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : IsNotEmptyOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not Empty", target.Symbol);
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