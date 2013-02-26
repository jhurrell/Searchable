using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class NullableBoolOperatorTests
	{
		protected List<Operator> Operators = OperatorSupport.GetSupportedOperators(typeof(bool?));

		[TestMethod]
		public void Supports_Between()
		{
			CollectionAssert.Contains(Operators, new DoesNotHaveValueOperator());
		}

		[TestMethod]
		public void Supports_NotEqualTo()
		{
			CollectionAssert.Contains(Operators, new HasValueOperator());
		}

		[TestMethod]
		public void Supports_DoesNotHaveValue()
		{
			CollectionAssert.Contains(Operators, new IsFalseOperator());
		}

		[TestMethod]
		public void Supports_Equals()
		{
			CollectionAssert.Contains(Operators, new IsTrueOperator());
		}
	}
}
