using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.Operators;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class NullableDecimalOperatorTests
	{
		protected List<BaseOperator> Operators = OperatorSupport.GetSupportedOperators(typeof(decimal?));

		[TestMethod]
		public void Supports_Between()
		{
			CollectionAssert.Contains(Operators, new BetweenOperator());
		}

		[TestMethod]
		public void Supports_NotEqualTo()
		{
			CollectionAssert.Contains(Operators, new NotEqualToOperator());
		}

		[TestMethod]
		public void Supports_DoesNotHaveValue()
		{
			CollectionAssert.Contains(Operators, new DoesNotHaveValueOperator());
		}

		[TestMethod]
		public void Supports_Equals()
		{
			CollectionAssert.Contains(Operators, new EqualToOperator());
		}

		[TestMethod]
		public void Supports_GreaterThan()
		{
			CollectionAssert.Contains(Operators, new GreaterThanOperator());
		}

		[TestMethod]
		public void Supports_GreaterThanOrEqualTo()
		{
			CollectionAssert.Contains(Operators, new GreaterThanOrEqualToOperator());
		}
		
		[TestMethod]
		public void Supports_HasValue()
		{
			CollectionAssert.Contains(Operators, new HasValueOperator());
		}
		
		[TestMethod]
		public void Supports_IsNotOneOf()
		{
			CollectionAssert.Contains(Operators, new IsNotOneOfOperator());
		}
		
		[TestMethod]
		public void Supports_IsOneOf()
		{
			CollectionAssert.Contains(Operators, new IsOneOfOperator());
		}
		
		[TestMethod]
		public void Supports_LessThan()
		{
			CollectionAssert.Contains(Operators, new LessThanOperator());
		}
		
		[TestMethod]
		public void Supports_LessThanOrEqualTo()
		{
			CollectionAssert.Contains(Operators, new LessThanOrEqualToOperator());
		}
	}
}
