using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsNotOneOfOperatorTests
	{
		protected IsNotOneOfOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsNotOneOfOperator();
		}

		[TestClass]
		public class OperatorTests : IsNotOneOfOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operators.IsNotOneOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsNotOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not One Of", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsNotOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is Not One Of", target.Display);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsNotOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsNotOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(1, target.MaxValuesRequired);
			}
		}
	}
}