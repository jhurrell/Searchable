using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class IEnumerableOperatorTests
	{
		protected List<BaseOperator> Operators = OperatorSupport.GetSupportedOperators(typeof(IEnumerable));

		[TestMethod]
		public void Supports_IsEmpty()
		{
			CollectionAssert.Contains(Operators, new IsEmptyOperator());
		}

		[TestMethod]
		public void Supports_IsNotEmpty()
		{
			CollectionAssert.Contains(Operators, new IsNotEmptyOperator());
		}

		[TestMethod]
		public void Supports_ContainsOneOf()
		{
			CollectionAssert.Contains(Operators, new ContainsOneOfOperator());
		}

		[TestMethod]
		public void Supports_ContainsNoneOf()
		{
			CollectionAssert.Contains(Operators, new ContainsNoneOfOperator());
		}

		[TestMethod]
		public void Supports_ContainsAllOf()
		{
			CollectionAssert.Contains(Operators, new ContainsAllOfOperator());
		}
	}
}
