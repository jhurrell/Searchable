using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchBuilder.Tests.OperatorSupportTests
{
	[TestClass]
	public class IsTypeSupportedTests
	{

		[TestMethod]
		public void IsTypeSupported_GivenDateTime_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(DateTime)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenBool_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(bool)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenByte_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(byte)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenChar_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(char)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenDecimal_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(decimal)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenDouble_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(double)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenFloat_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(float)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenInt_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(int)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenLong_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(long)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenSbyte_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(sbyte)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenShort_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(short)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenUint_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(uint)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenUlong_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ulong)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenUshort_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ushort)));
		}
		[TestMethod]
		public void IsTypeSupported_GivenNullableDateTime_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(DateTime?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableBool_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(bool?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableByte_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(byte?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableChar_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(char?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableDecimal_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(decimal?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableDouble_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(double?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableFloat_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(float?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableInt_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(int?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableLong_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(long?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableSbyte_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(sbyte?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableShort_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(short?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableUint_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(uint?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableUlong_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ulong?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenNullableUshort_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ushort?)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenString_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(string)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenIEnumerableBaseArray_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(Array)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenIEnumerableArray_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(object[])));
		}

		[TestMethod]
		public void IsTypeSupported_GivenIEnumerable_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(IEnumerable)));
		}

		[TestMethod]
		public void IsTypeSupported_GivenIEnumerableGeneric_ReturnsTrue()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(IEnumerable<>)));
		}
	}
}
