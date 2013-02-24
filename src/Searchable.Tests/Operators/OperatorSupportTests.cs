using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Searchable.Operators;

namespace SearchableTests.Operators
{
	[TestClass]
	public class OperatorSupportTests
	{
		[TestClass]
		public class GetSupportedOperatorsTests : OperatorSupportTests
		{
			[TestMethod]
			[ExpectedException(typeof(ArgumentException))]
			public void Throw_Exception_Given_Unsupported_Type()
			{
				var result = OperatorSupport.GetSupportedOperators(typeof(OperatorSupport));
			}

			[TestMethod]
			public void Bool()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(bool)));
			}

			[TestMethod]
			public void Byte()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(byte)));
			}

			[TestMethod]
			public void Char()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(char)));
			}

			[TestMethod]
			public void DateTime()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(DateTime)));
			}

			[TestMethod]
			public void Decimal()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(decimal)));
			}

			[TestMethod]
			public void Double()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(double)));
			}

			[TestMethod]
			public void Float()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(float)));
			}

			[TestMethod]
			public void Int()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(int)));
			}

			[TestMethod]
			public void Long()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(long)));
			}

			[TestMethod]
			public void Sbyte()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(sbyte)));
			}

			[TestMethod]
			public void Short()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(short)));
			}

			[TestMethod]
			public void String()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(string)));
			}

			[TestMethod]
			public void Uint()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(uint)));
			}

			[TestMethod]
			public void Ulong()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(ulong)));
			}

			[TestMethod]
			public void Ushort()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(ushort)));
			}

			[TestMethod]
			public void NullableBool()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(bool?)));
			}

			[TestMethod]
			public void NullableByte()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(byte?)));
			}

			[TestMethod]
			public void NullableChar()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(char?)));
			}

			[TestMethod]
			public void NullableDateTime()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(DateTime?)));
			}

			[TestMethod]
			public void NullableDecimal()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(decimal?)));
			}

			[TestMethod]
			public void NullableDouble()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(double?)));
			}

			[TestMethod]
			public void NullableFloat()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(float?)));
			}

			[TestMethod]
			public void NullableInt()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(int?)));
			}

			[TestMethod]
			public void NullableLong()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(long?)));
			}

			[TestMethod]
			public void NullableShotr()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(short?)));
			}

			[TestMethod]
			public void NullableSbyte()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(sbyte?)));
			}

			[TestMethod]
			public void NullableUint()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(uint?)));
			}

			[TestMethod]
			public void NullableUlong()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(ulong?)));
			}

			[TestMethod]
			public void NullableUshort()
			{
				Assert.IsNotNull(OperatorSupport.GetSupportedOperators(typeof(ushort?)));
			}
		}
	}
}
