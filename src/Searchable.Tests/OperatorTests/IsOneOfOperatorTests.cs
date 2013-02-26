using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

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
				Assert.AreEqual(Operators.IsOneOf, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is One Of", target.Name);
			}
		}

		[TestClass]
		public class DisplayTests : IsOneOfOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is One Of", target.Display);
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