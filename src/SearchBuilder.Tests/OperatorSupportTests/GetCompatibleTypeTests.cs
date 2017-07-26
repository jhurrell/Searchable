using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchBuilder.Tests.OperatorSupportTests
{
	[TestClass]
	public class GetCompatibleTypeTests
	{
		[TestMethod]
		public void GetCompatibleType_GivenDateTime_ReturnsDateTime()
		{
			Assert.AreEqual(typeof(DateTime), OperatorSupport.GetCompatibleType(typeof(DateTime)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableDateTime_ReturnsDateTime()
		{
			Assert.AreEqual(typeof(DateTime), OperatorSupport.GetCompatibleType(typeof(DateTime?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenBool_ReturnsBool()
		{
			Assert.AreEqual(typeof(bool), OperatorSupport.GetCompatibleType(typeof(bool)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableBool_ReturnsBool()
		{
			Assert.AreEqual(typeof(bool), OperatorSupport.GetCompatibleType(typeof(bool?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenByte_ReturnsByte()
		{
			Assert.AreEqual(typeof(byte), OperatorSupport.GetCompatibleType(typeof(byte)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableByte_ReturnsByte()
		{
			Assert.AreEqual(typeof(byte), OperatorSupport.GetCompatibleType(typeof(byte?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenChar_ReturnsChar()
		{
			Assert.AreEqual(typeof(char), OperatorSupport.GetCompatibleType(typeof(char)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableChar_ReturnsChar()
		{
			Assert.AreEqual(typeof(char), OperatorSupport.GetCompatibleType(typeof(char?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenDecimal_ReturnsDecimal()
		{
			Assert.AreEqual(typeof(decimal), OperatorSupport.GetCompatibleType(typeof(decimal)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableDecimal_ReturnsDecimal()
		{
			Assert.AreEqual(typeof(decimal), OperatorSupport.GetCompatibleType(typeof(decimal?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenDouble_ReturnsDouble()
		{
			Assert.AreEqual(typeof(double), OperatorSupport.GetCompatibleType(typeof(double)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableDouble_ReturnsDouble()
		{
			Assert.AreEqual(typeof(double), OperatorSupport.GetCompatibleType(typeof(double?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenFloat_ReturnsFloat()
		{
			Assert.AreEqual(typeof(float), OperatorSupport.GetCompatibleType(typeof(float)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableFloat_ReturnsFloat()
		{
			Assert.AreEqual(typeof(float), OperatorSupport.GetCompatibleType(typeof(float?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenInt_ReturnsInt()
		{
			Assert.AreEqual(typeof(int), OperatorSupport.GetCompatibleType(typeof(int)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableInt_ReturnsInt()
		{
			Assert.AreEqual(typeof(int), OperatorSupport.GetCompatibleType(typeof(int?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenLong_ReturnsLong()
		{
			Assert.AreEqual(typeof(long), OperatorSupport.GetCompatibleType(typeof(long)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableLong_ReturnsLong()
		{
			Assert.AreEqual(typeof(long), OperatorSupport.GetCompatibleType(typeof(long?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenSbyte_ReturnsSbyte()
		{
			Assert.AreEqual(typeof(sbyte), OperatorSupport.GetCompatibleType(typeof(sbyte)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableSbyte_ReturnsSbyte()
		{
			Assert.AreEqual(typeof(sbyte), OperatorSupport.GetCompatibleType(typeof(sbyte?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenShort_ReturnsShort()
		{
			Assert.AreEqual(typeof(short), OperatorSupport.GetCompatibleType(typeof(short)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableShort_ReturnsShort()
		{
			Assert.AreEqual(typeof(short), OperatorSupport.GetCompatibleType(typeof(short?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenUint_ReturnsUint()
		{
			Assert.AreEqual(typeof(uint), OperatorSupport.GetCompatibleType(typeof(uint)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableUint_ReturnsUint()
		{
			Assert.AreEqual(typeof(uint), OperatorSupport.GetCompatibleType(typeof(uint?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenUlong_ReturnsUlong()
		{
			Assert.AreEqual(typeof(ulong), OperatorSupport.GetCompatibleType(typeof(ulong)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableUlong_ReturnsUlong()
		{
			Assert.AreEqual(typeof(ulong), OperatorSupport.GetCompatibleType(typeof(ulong?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenUshort_ReturnsUshort()
		{
			Assert.AreEqual(typeof(ushort), OperatorSupport.GetCompatibleType(typeof(ushort)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenNullableUshort_ReturnsUshort()
		{
			Assert.AreEqual(typeof(ushort), OperatorSupport.GetCompatibleType(typeof(ushort?)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenString_ReturnsString()
		{
			Assert.AreEqual(typeof(string), OperatorSupport.GetCompatibleType(typeof(string)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenIEnumerableBaseArray_ReturnsIEnumerableBaseArray()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(Array)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenIEnumerableArray_ReturnsIEnumerableArray()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(object[])));
		}

		[TestMethod]
		public void GetCompatibleType_GivenIEnumerable_ReturnsIEnumerable()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(IEnumerable)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenIEnumerableGeneric_ReturnsIEnumerable()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(IEnumerable<>)));
		}

		[TestMethod]
		public void GetCompatibleType_GivenEnumableGeneric_ReturnsEnum()
		{
			Assert.AreEqual(typeof(Enum), OperatorSupport.GetCompatibleType(typeof(Enum)));
		}
	}
}
