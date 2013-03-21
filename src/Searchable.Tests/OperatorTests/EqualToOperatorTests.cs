using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

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
				Assert.AreEqual(Operator.EqualTo, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("EqualTo", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Equal To", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : EqualToOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("=", target.Symbol);
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
