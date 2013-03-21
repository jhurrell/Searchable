﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchableTests.OperatorTests
{
	[TestClass]
	public class IsFalseOperatorTests
	{
		protected IsFalseOperator target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new IsFalseOperator();
		}

		[TestClass]
		public class OperatorTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Value()
			{
				Assert.AreEqual(Operator.IsFalse, target.OperatorType);
			}
		}

		[TestClass]
		public class NameTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("IsFalse", target.Name);
			}
		}

		[TestClass]
		public class DisplayNameTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("Is False", target.DisplayName);
			}
		}

		[TestClass]
		public class SymbolTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual("False", target.Symbol);
			}
		}

		[TestClass]
		public class MinValuesRequiredTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MinValuesRequired);
			}
		}

		[TestClass]
		public class MaxValuesRequiredTests : IsFalseOperatorTests
		{
			[TestMethod]
			public void Is_Set()
			{
				Assert.AreEqual(0, target.MaxValuesRequired);
			}
		}
	}
}
