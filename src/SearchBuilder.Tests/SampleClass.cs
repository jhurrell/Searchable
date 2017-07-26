using System;
using System.Collections.Generic;

namespace SearchBuilder.Tests
{
	public class SampleClass
	{
		// Numeric types.
		public byte ByteProperty { get; set; }
		public int IntProperty { get; set; }
		public long LongProperty { get; set; }
		public sbyte SbtyeProperty { get; set; }
		public int ShortProperty { get; set; }
		public ushort UshortProperty { get; set; }
		public uint UintProperty { get; set; }
		public ulong UlongProperty { get; set; }
		public float FloatProperty { get; set; }
		public double DoubleProperty { get; set; }
		public decimal DecimalProperty { get; set; }
		public char CharProperty { get; set; }
		public bool BoolProperty { get; set; }
		public DateTime DateTimeProperty { get; set; }
		public SampleEnum EnumProperty { get; set; }

		// Nullable numeric types.
		public byte? NullableByteProperty { get; set; }
		public int? NullableIntProperty { get; set; }
		public long? NullableLongProperty { get; set; }
		public sbyte? NullableSbtyeProperty { get; set; }
		public int? NullableShortProperty { get; set; }
		public ushort? NullableUshortProperty { get; set; }
		public uint? NullableUintProperty { get; set; }
		public ulong? NullableUlongProperty { get; set; }
		public float? NullableFloatProperty { get; set; }
		public double? NullableDoubleProperty { get; set; }
		public decimal? NullableDecimalProperty { get; set; }
		public char? NullableCharProperty { get; set; }
		public bool? NullableBoolProperty { get; set; }
		public DateTime? NullableDateTimeProperty { get; set; }

		//// String type.
		public string StringProperty { get; set; }

		//// Collection types.
		public IEnumerable<object> ObjectEnumerable { get; set; }
		public object[] ObjectArray { get; set; }

		// Unsupported types.
		private string PrivateProperty { get; set; }
		protected string ProtectedProperty { get; set; }
		public Component Component { get; set; }

		// Methods.
		public void SomeVoidMethod() { }
		public string SomeStringMethod() { return string.Empty; }

		public SampleClass()
		{
			PrivateProperty = string.Empty;
		}
	}

	public class Component
	{
	}

	public enum SampleEnum
	{
		Small,
		Medium,
		Large
	}
}
