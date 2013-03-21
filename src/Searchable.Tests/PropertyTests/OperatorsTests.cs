﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class OperatorsTests
	{
		protected PropertyOperators target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new PropertyOperators();
		}

		[TestMethod]
		public void Collection_Populated()
		{
			Assert.IsTrue(target["StringProperty"].Operators.Count > 0);
		}
	}

	public class PropertyOperators : SearchBuilder<SampleClass>
	{
		public PropertyOperators()
		{
			AddProperty(p => p.StringProperty);
		}
	}
}
