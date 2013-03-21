using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class NotBetweenOperatorTests
	{
		protected NotBetweenOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new NotBetweenOperator();
		}

		[TestClass]
		public class OperatorTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.NotBetween, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("NotBetween", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Not Between", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Not Between", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(2, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : NotBetweenOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(2, target.MaxValuesRequired);
			}
		}
	}
}
