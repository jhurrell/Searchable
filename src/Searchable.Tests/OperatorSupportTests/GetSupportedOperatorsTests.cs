using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class GetSupportedOperatorsTests
	{
		protected List<OperatorBase> booleanOperators { get; set; }
		protected List<OperatorBase> numericOperators { get; set; }
		protected List<OperatorBase> stringOperators { get; set; }
		protected List<OperatorBase> ienumerableOperators { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			booleanOperators = new List<OperatorBase>
			{
				new DoesNotHaveValueOperator(),
				new HasValueOperator(),
				new IsFalseOperator(),
				new IsTrueOperator(),
			};

			numericOperators = new List<OperatorBase>
			{
				new BetweenOperator(),
				new DoesNotHaveValueOperator(),
				new EqualToOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
				new NotEqualToOperator(),
			};

			stringOperators = new List<OperatorBase>
			{
				new BeginsWithOperator(),
				new BetweenOperator(),
				new ContainsOperator(),
				new DoesNotContainOperator(),
				new DoesNotHaveValueOperator(),
				new EndsWithOperator(),
				new EqualToOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
				new NotEqualToOperator(),
			};

			ienumerableOperators = new List<OperatorBase>
			{
				new ContainsAllOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsOneOfOperator(),
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),

			};
		}

		[TestMethod]
		public void Does_Not_Return_Reference_To_Collection()
		{
			var operators = OperatorSupport.GetSupportedOperators(typeof(string));
			operators.Clear();
			CollectionAssert.AreEquivalent(stringOperators, OperatorSupport.GetSupportedOperators(typeof(string)));
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Throw_Exception_Given_Unsupported_Type()
		{
			var result = OperatorSupport.GetSupportedOperators(this.GetType());
		}

		[TestMethod]
		public void DateTime_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(DateTime)));
		}

		[TestMethod]
		public void NullableDateTime_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(DateTime?)));
		}

		[TestMethod]
		public void Boolean_Operators()
		{
			CollectionAssert.AreEquivalent(booleanOperators, OperatorSupport.GetSupportedOperators(typeof(bool)));
		}

		[TestMethod]
		public void NullableBoolean_Operators()
		{
			CollectionAssert.AreEquivalent(booleanOperators, OperatorSupport.GetSupportedOperators(typeof(bool?)));
		}

		[TestMethod]
		public void Byte_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(byte)));
		}

		[TestMethod]
		public void NullableByte_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(byte?)));
		}

		[TestMethod]
		public void Char_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(char)));
		}

		[TestMethod]
		public void NullableChar_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(char?)));
		}

		[TestMethod]
		public void Decimal_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(decimal)));
		}

		[TestMethod]
		public void NullableDecimal_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(decimal?)));
		}

		[TestMethod]
		public void Double_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(double)));
		}

		[TestMethod]
		public void NullableDouble_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(double?)));
		}

		[TestMethod]
		public void Float_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(float)));
		}

		[TestMethod]
		public void NullableFloat_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(float?)));
		}

		[TestMethod]
		public void Int_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(int)));
		}

		[TestMethod]
		public void NullableInt_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(int?)));
		}

		[TestMethod]
		public void Long_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(long)));
		}

		[TestMethod]
		public void NullableLong_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(long?)));
		}

		[TestMethod]
		public void Sbyte_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(sbyte)));
		}

		[TestMethod]
		public void NullableSbyte_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(sbyte?)));
		}

		[TestMethod]
		public void Short_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(short)));
		}

		[TestMethod]
		public void NullableShort_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(short?)));
		}

		[TestMethod]
		public void Uint_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(uint)));
		}

		[TestMethod]
		public void NullableUint_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(uint?)));
		}

		[TestMethod]
		public void Ulong_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ulong)));
		}

		[TestMethod]
		public void NullableUlong_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ulong?)));
		}

		[TestMethod]
		public void Ushort_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ushort)));
		}

		[TestMethod]
		public void NullableUshort_Operators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ushort?)));
		}

		[TestMethod]
		public void String_Operators()
		{
			CollectionAssert.AreEquivalent(stringOperators, OperatorSupport.GetSupportedOperators(typeof(string)));
		}

		[TestMethod]
		public void IEnumerableBaseArray_Operators()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(Array)));	
		}

		[TestMethod]
		public void IEnumerableArray_Operators()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(object[])));
		}

		[TestMethod]
		public void IEnumerable_Operators()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(IEnumerable)));
		}

		[TestMethod]
		public void IEnumerableGeneric_Operators()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(IEnumerable<>)));
		}
	}
}
