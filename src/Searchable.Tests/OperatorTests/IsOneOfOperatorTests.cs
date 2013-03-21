using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsOneOfOperatorTests
	{
		protected IsOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsOneOfOperator();
		}

		[TestClass]
		public class OperatorTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.IsOneOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("IsOneOf", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is One Of", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is One Of", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}