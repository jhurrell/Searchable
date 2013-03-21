using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchableTests.OperatorSupportTests
{
	[TestClass]
	public class IsTypeSupportedTests
	{

		[TestMethod]
		public void DateTime_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(DateTime)));
		}

		[TestMethod]
		public void Bool_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(bool)));
		}

		[TestMethod]
		public void Byte_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(byte)));
		}

		[TestMethod]
		public void Char_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(char)));
		}

		[TestMethod]
		public void Decimal_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(decimal)));
		}

		[TestMethod]
		public void Double_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(double)));
		}

		[TestMethod]
		public void Float_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(float)));
		}

		[TestMethod]
		public void Int_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(int)));
		}

		[TestMethod]
		public void Long_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(long)));
		}

		[TestMethod]
		public void Sbyte_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(sbyte)));
		}

		[TestMethod]
		public void Short_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(short)));
		}

		[TestMethod]
		public void Uint_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(uint)));
		}

		[TestMethod]
		public void Ulong_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ulong)));
		}

		[TestMethod]
		public void Ushort_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ushort)));
		}
		[TestMethod]
		public void NullableDateTime_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(DateTime?)));
		}

		[TestMethod]
		public void NullableBool_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(bool?)));
		}

		[TestMethod]
		public void NullableByte_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(byte?)));
		}

		[TestMethod]
		public void NullableChar_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(char?)));
		}

		[TestMethod]
		public void NullableDecimal_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(decimal?)));
		}

		[TestMethod]
		public void NullableDouble_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(double?)));
		}

		[TestMethod]
		public void NullableFloat_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(float?)));
		}

		[TestMethod]
		public void NullableInt_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(int?)));
		}

		[TestMethod]
		public void NullableLong_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(long?)));
		}

		[TestMethod]
		public void NullableSbyte_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(sbyte?)));
		}

		[TestMethod]
		public void NullableShort_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(short?)));
		}

		[TestMethod]
		public void NullableUint_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(uint?)));
		}

		[TestMethod]
		public void NullableUlong_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ulong?)));
		}

		[TestMethod]
		public void NullableUshort_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(ushort?)));
		}

		[TestMethod]
		public void String_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(string)));
		}

		[TestMethod]
		public void IEnumerableBaseArray_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(Array)));
		}

		[TestMethod]
		public void IEnumerableArray_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(object[])));
		}

		[TestMethod]
		public void IEnumerable_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(IEnumerable)));
		}

		[TestMethod]
		public void IEnumerableGeneric_Returns_True()
		{
			Assert.IsTrue(OperatorSupport.IsTypeSupported(typeof(IEnumerable<>)));
		}

	}
}
