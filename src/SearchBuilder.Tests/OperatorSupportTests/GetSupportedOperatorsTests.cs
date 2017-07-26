using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchBuilder.Tests.OperatorSupportTests
{
	[TestClass]
	public class GetSupportedOperatorsTests
	{
		protected List<OperatorBase> booleanOperators { get; set; }
		protected List<OperatorBase> numericOperators { get; set; }
		protected List<OperatorBase> stringOperators { get; set; }
		protected List<OperatorBase> ienumerableOperators { get; set; }
		protected List<OperatorBase> enumOperators { get; set; }

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

			enumOperators = new List<OperatorBase>
			{
				new EqualToOperator(),
				new NotEqualToOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
			};
		}

		[TestMethod]
		public void GetSupportedOperators_GivenSupportedType_DoesNotReturnReferenceToCollection()
		{
			var operators = OperatorSupport.GetSupportedOperators(typeof(string));
			operators.Clear();
			CollectionAssert.AreEquivalent(stringOperators, OperatorSupport.GetSupportedOperators(typeof(string)));
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetSupportedOperators_GivenUnsupportedType_ThrowsException()
		{
			var result = OperatorSupport.GetSupportedOperators(this.GetType());
		}

		[TestMethod]
		public void GetSupportedOperators_GivenDateTime_ReturnsNumericOperators()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(DateTime)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableDateTime_ReturnsDateTime()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(DateTime?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenBoolean_ReturnsBoolean()
		{
			var expected = booleanOperators;
			var actual = OperatorSupport.GetSupportedOperators(typeof(bool));
			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableBoolean_ReturnsBoolean()
		{
			CollectionAssert.AreEquivalent(booleanOperators, OperatorSupport.GetSupportedOperators(typeof(bool?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenByte_ReturnsByte()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(byte)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableByte_ReturnsByte()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(byte?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenChar_ReturnsChar()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(char)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableChar_ReturnsChar()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(char?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenDecimal_ReturnsDecimal()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(decimal)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableDecimal_ReturnsDecimal()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(decimal?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenDouble_ReturnsDouble()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(double)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableDouble_ReturnsDouble()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(double?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenFloat_ReturnsFloat()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(float)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableFloat_ReturnsFloat()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(float?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenInt_ReturnsInt()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(int)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableInt_ReturnsInt()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(int?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenLong_ReturnsLong()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(long)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableLong_ReturnsLong()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(long?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenSbyte_ReturnsSbyte()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(sbyte)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableSbyte_ReturnsSbyte()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(sbyte?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenShort_ReturnsShort()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(short)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableShort_ReturnsShort()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(short?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenUint_ReturnsUint()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(uint)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableUint_ReturnsUint()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(uint?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenUlong_ReturnsUlong()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ulong)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableUlong_ReturnsUlong()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ulong?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenUshort_ReturnsUshort()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ushort)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenNullableUshort_ReturnsUshort()
		{
			CollectionAssert.AreEquivalent(numericOperators, OperatorSupport.GetSupportedOperators(typeof(ushort?)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenString_ReturnsString()
		{
			CollectionAssert.AreEquivalent(stringOperators, OperatorSupport.GetSupportedOperators(typeof(string)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenIEnumerableBaseArray_ReturnsIEnumerableBaseArray()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(Array)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenIEnumerableArray_ReturnsIEnumerableArray()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(object[])));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenIEnumerable_ReturnsIEnumerable()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(IEnumerable)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenIEnumerableGeneric_ReturnsIEnumerableGeneric()
		{
			CollectionAssert.AreEquivalent(ienumerableOperators, OperatorSupport.GetSupportedOperators(typeof(IEnumerable<>)));
		}

		[TestMethod]
		public void GetSupportedOperators_GivenEnum_ReturnsEnum()
		{
			CollectionAssert.AreEquivalent(enumOperators, OperatorSupport.GetSupportedOperators(typeof(Enum)));
		}
	}
}
