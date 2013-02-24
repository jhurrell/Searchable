using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Searchable.Operators;

namespace SearchableTests.Operators
{
	[TestClass]
	public class OperatorSupportTests
	{
		protected OperatorSupport target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new OperatorSupport();
		}

		[TestClass]
		public class IndexerTests : OperatorSupportTests
		{
			[TestMethod]
			[ExpectedException(typeof(ArgumentException))]
			public void Throw_Exception_Given_Unsupported_Type()
			{
				var result = target[typeof(OperatorSupport)];
			}
		}

		[TestClass]
		public class TypesSupportedTests : OperatorSupportTests
		{
			[TestMethod]
			public void Bool()
			{
				Assert.IsNotNull(target[typeof(bool)]);
			}

			[TestMethod]
			public void Byte()
			{
				Assert.IsNotNull(target[typeof(byte)]);
			}

			[TestMethod]
			public void Char()
			{
				Assert.IsNotNull(target[typeof(char)]);
			}

			[TestMethod]
			public void DateTime()
			{
				Assert.IsNotNull(target[typeof(DateTime)]);
			}

			[TestMethod]
			public void Decimal()
			{
				Assert.IsNotNull(target[typeof(decimal)]);
			}

			[TestMethod]
			public void Double()
			{
				Assert.IsNotNull(target[typeof(double)]);
			}

			[TestMethod]
			public void Float()
			{
				Assert.IsNotNull(target[typeof(float)]);
			}

			[TestMethod]
			public void Int()
			{
				Assert.IsNotNull(target[typeof(int)]);
			}

			[TestMethod]
			public void Long()
			{
				Assert.IsNotNull(target[typeof(long)]);
			}

			[TestMethod]
			public void Sbyte()
			{
				Assert.IsNotNull(target[typeof(sbyte)]);
			}

			[TestMethod]
			public void Short()
			{
				Assert.IsNotNull(target[typeof(short)]);
			}

			[TestMethod]
			public void String()
			{
				Assert.IsNotNull(target[typeof(string)]);
			}

			[TestMethod]
			public void Uint()
			{
				Assert.IsNotNull(target[typeof(uint)]);
			}

			[TestMethod]
			public void Ulong()
			{
				Assert.IsNotNull(target[typeof(ulong)]);
			}

			[TestMethod]
			public void Ushort()
			{
				Assert.IsNotNull(target[typeof(ushort)]);
			}

			[TestMethod]
			public void NullableBool()
			{
				Assert.IsNotNull(target[typeof(bool?)]);
			}

			[TestMethod]
			public void NullableByte()
			{
				Assert.IsNotNull(target[typeof(byte?)]);
			}

			[TestMethod]
			public void NullableChar()
			{
				Assert.IsNotNull(target[typeof(char?)]);
			}

			[TestMethod]
			public void NullableDateTime()
			{
				Assert.IsNotNull(target[typeof(DateTime?)]);
			}

			[TestMethod]
			public void NullableDecimal()
			{
				Assert.IsNotNull(target[typeof(decimal?)]);
			}

			[TestMethod]
			public void NullableDouble()
			{
				Assert.IsNotNull(target[typeof(double?)]);
			}

			[TestMethod]
			public void NullableFloat()
			{
				Assert.IsNotNull(target[typeof(float?)]);
			}

			[TestMethod]
			public void NullableInt()
			{
				Assert.IsNotNull(target[typeof(int?)]);
			}

			[TestMethod]
			public void NullableLong()
			{
				Assert.IsNotNull(target[typeof(long?)]);
			}

			[TestMethod]
			public void NullableShotr()
			{
				Assert.IsNotNull(target[typeof(short?)]);
			}

			[TestMethod]
			public void NullableSbyte()
			{
				Assert.IsNotNull(target[typeof(sbyte?)]);
			}

			[TestMethod]
			public void NullableUint()
			{
				Assert.IsNotNull(target[typeof(uint?)]);
			}

			[TestMethod]
			public void NullableUlong()
			{
				Assert.IsNotNull(target[typeof(ulong?)]);
			}

			[TestMethod]
			public void NullableUshort()
			{
				Assert.IsNotNull(target[typeof(ushort?)]);
			}
		}

		[TestClass]
		public class StringTypeTests : OperatorSupportTests
		{

			
		}
	}
}
