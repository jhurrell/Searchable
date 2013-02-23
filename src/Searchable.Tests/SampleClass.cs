﻿namespace SearchableTests
{
	public class SampleClass
	{
		// Value types.
		public byte ByteProperty { get; set; }
		public sbyte SbtyeProperty { get; set; }
		public int ShortProperty { get; set; }
		public ushort UshortProperty { get; set; }
		public int IntProperty { get; set; }
		public uint UintProperty { get; set; }
		public long LongProperty { get; set; }
		public ulong UlongProperty { get; set; }
		public float FloatProperty { get; set; }
		public double DoubleProperty { get; set; }
		public decimal DecimalProperty { get; set; }
		public char CharProperty { get; set; }
		public string StringProperty { get; set; }
		public bool BoolProperty { get; set; }

		// Nullable value types.
		public byte? NullableByteProperty { get; set; }
		public sbyte? NullableSbtyeProperty { get; set; }
		public int? NullableShortProperty { get; set; }
		public ushort? NullableUshortProperty { get; set; }
		public int? NullableIntProperty { get; set; }
		public uint? NullableUintProperty { get; set; }
		public long? NullableLongProperty { get; set; }
		public ulong? NullableUlongProperty { get; set; }
		public float? NullableFloatProperty { get; set; }
		public double? NullableDoubleProperty { get; set; }
		public decimal? NullableDecimalProperty { get; set; }
		public char? NullableCharProperty { get; set; }
		public bool? NullableBoolProperty { get; set; }

		// Unsupported types.
		private string PrivateProperty { get; set; }
	}
}
