using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class GetCompatibleTypeTests
	{
		[TestMethod]
		public void DateTime_Type()
		{
			Assert.AreEqual(typeof(DateTime), OperatorSupport.GetCompatibleType(typeof(DateTime)));
		}

		[TestMethod]
		public void NullableDateTime_Type()
		{
			Assert.AreEqual(typeof(DateTime), OperatorSupport.GetCompatibleType(typeof(DateTime?)));
		}

		[TestMethod]
		public void Boolean_Type()
		{
			Assert.AreEqual(typeof(bool), OperatorSupport.GetCompatibleType(typeof(bool)));
		}

		[TestMethod]
		public void NullableBoolean_Type()
		{
			Assert.AreEqual(typeof(bool), OperatorSupport.GetCompatibleType(typeof(bool?)));
		}

		[TestMethod]
		public void Byte_Type()
		{
			Assert.AreEqual(typeof(byte), OperatorSupport.GetCompatibleType(typeof(byte)));
		}

		[TestMethod]
		public void NullableByte_Type()
		{
			Assert.AreEqual(typeof(byte), OperatorSupport.GetCompatibleType(typeof(byte?)));
		}

		[TestMethod]
		public void Char_Type()
		{
			Assert.AreEqual(typeof(char), OperatorSupport.GetCompatibleType(typeof(char)));
		}

		[TestMethod]
		public void NullableChar_Type()
		{
			Assert.AreEqual(typeof(char), OperatorSupport.GetCompatibleType(typeof(char?)));
		}

		[TestMethod]
		public void Decimal_Type()
		{
			Assert.AreEqual(typeof(decimal), OperatorSupport.GetCompatibleType(typeof(decimal)));
		}

		[TestMethod]
		public void NullableDecimal_Type()
		{
			Assert.AreEqual(typeof(decimal), OperatorSupport.GetCompatibleType(typeof(decimal?)));
		}

		[TestMethod]
		public void Double_Type()
		{
			Assert.AreEqual(typeof(double), OperatorSupport.GetCompatibleType(typeof(double)));
		}

		[TestMethod]
		public void NullableDouble_Type()
		{
			Assert.AreEqual(typeof(double), OperatorSupport.GetCompatibleType(typeof(double?)));
		}

		[TestMethod]
		public void Float_Type()
		{
			Assert.AreEqual(typeof(float), OperatorSupport.GetCompatibleType(typeof(float)));
		}

		[TestMethod]
		public void NullableFloat_Type()
		{
			Assert.AreEqual(typeof(float), OperatorSupport.GetCompatibleType(typeof(float?)));
		}

		[TestMethod]
		public void Int_Type()
		{
			Assert.AreEqual(typeof(int), OperatorSupport.GetCompatibleType(typeof(int)));
		}

		[TestMethod]
		public void NullableInt_Type()
		{
			Assert.AreEqual(typeof(int), OperatorSupport.GetCompatibleType(typeof(int?)));
		}

		[TestMethod]
		public void Long_Type()
		{
			Assert.AreEqual(typeof(long), OperatorSupport.GetCompatibleType(typeof(long)));
		}

		[TestMethod]
		public void NullableLong_Type()
		{
			Assert.AreEqual(typeof(long), OperatorSupport.GetCompatibleType(typeof(long?)));
		}

		[TestMethod]
		public void Sbyte_Type()
		{
			Assert.AreEqual(typeof(sbyte), OperatorSupport.GetCompatibleType(typeof(sbyte)));
		}

		[TestMethod]
		public void NullableSbyte_Type()
		{
			Assert.AreEqual(typeof(sbyte), OperatorSupport.GetCompatibleType(typeof(sbyte?)));
		}

		[TestMethod]
		public void Short_Type()
		{
			Assert.AreEqual(typeof(short), OperatorSupport.GetCompatibleType(typeof(short)));
		}

		[TestMethod]
		public void NullableShort_Type()
		{
			Assert.AreEqual(typeof(short), OperatorSupport.GetCompatibleType(typeof(short?)));
		}

		[TestMethod]
		public void Uint_Type()
		{
			Assert.AreEqual(typeof(uint), OperatorSupport.GetCompatibleType(typeof(uint)));
		}

		[TestMethod]
		public void NullableUint_Type()
		{
			Assert.AreEqual(typeof(uint), OperatorSupport.GetCompatibleType(typeof(uint?)));
		}

		[TestMethod]
		public void Ulong_Type()
		{
			Assert.AreEqual(typeof(ulong), OperatorSupport.GetCompatibleType(typeof(ulong)));
		}

		[TestMethod]
		public void NullableUlong_Type()
		{
			Assert.AreEqual(typeof(ulong), OperatorSupport.GetCompatibleType(typeof(ulong?)));
		}

		[TestMethod]
		public void Ushort_Type()
		{
			Assert.AreEqual(typeof(ushort), OperatorSupport.GetCompatibleType(typeof(ushort)));
		}

		[TestMethod]
		public void NullableUshort_Type()
		{
			Assert.AreEqual(typeof(ushort), OperatorSupport.GetCompatibleType(typeof(ushort?)));
		}

		[TestMethod]
		public void String_Type()
		{
			Assert.AreEqual(typeof(string), OperatorSupport.GetCompatibleType(typeof(string)));
		}

		[TestMethod]
		public void IEnumerableBaseArray_Type()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(Array)));
		}

		[TestMethod]
		public void IEnumerableArray_Type()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(object[])));
		}

		[TestMethod]
		public void IEnumerable_Type()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(IEnumerable)));
		}

		[TestMethod]
		public void IEnumerableGeneric_Type()
		{
			Assert.AreEqual(typeof(IEnumerable), OperatorSupport.GetCompatibleType(typeof(IEnumerable<>)));
		}
	}
}
