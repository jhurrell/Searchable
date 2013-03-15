using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using System;
using System.Linq;

namespace SearchableTests.ConfigurationTests
{
	[TestClass]
	public class RemovePropertyTests
	{
		[TestMethod]
		public void Resets_Collection()
		{
			var target = new RemovePropertySingle();
			Assert.AreEqual(28, target.Properties.Count);
		}

		[TestMethod]
		public void Removes_Property_From_Collection()
		{
			var target = new RemovePropertySingle();
			var expected = new string[] 
			{ 
				"ByteProperty",
				"SbtyeProperty",
				"ShortProperty",
				"UshortProperty",
				"IntProperty",
				"UintProperty",
				"LongProperty",
				"UlongProperty",
				"FloatProperty",
				"DoubleProperty",
				"DecimalProperty",
				"CharProperty",
				"NullableByteProperty",
				"NullableSbtyeProperty",
				"NullableShortProperty",
				"NullableUshortProperty",
				"NullableIntProperty",
				"NullableUintProperty",
				"NullableLongProperty",
				"NullableUlongProperty",
				"NullableFloatProperty",
				"NullableDoubleProperty",
				"NullableDecimalProperty",
				"NullableCharProperty",
				"NullableBoolProperty",
				"StringProperty",
				"ObjectEnumerable",
				"ObjectArray",
			};
			var actual = target.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void Does_Not_Reset_Additional_Properties()
		{
			var target = new RemovePropertyMultiple();
			var expected = new string[] 
			{ 
				"ByteProperty",
				"SbtyeProperty",
				"ShortProperty",
				"IntProperty",
				"UintProperty",
				"LongProperty",
				"UlongProperty",
				"FloatProperty",
				"DoubleProperty",
				"DecimalProperty",
				"CharProperty",
				"NullableByteProperty",
				"NullableSbtyeProperty",
				"NullableShortProperty",
				"NullableUshortProperty",
				"NullableIntProperty",
				"NullableUintProperty",
				"NullableLongProperty",
				"NullableUlongProperty",
				"NullableFloatProperty",
				"NullableDoubleProperty",
				"NullableDecimalProperty",
				"NullableCharProperty",
				"NullableBoolProperty",
				"StringProperty",
				"ObjectEnumerable",
				"ObjectArray",
			};
			var actual = target.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Can_Only_Remove_Property_Once()
		{
			var target = new RemovePropertyDuplicate();
		}
	}

	public class RemovePropertySingle : SearchBuilder<SampleClass>
	{
		public RemovePropertySingle()
		{
			RemoveProperty(p => p.BoolProperty);
		}
	}

	public class RemovePropertyMultiple : SearchBuilder<SampleClass>
	{
		public RemovePropertyMultiple()
		{
			RemoveProperty(p => p.BoolProperty);
			RemoveProperty(p => p.UshortProperty);
		}
	}

	public class RemovePropertyDuplicate : SearchBuilder<SampleClass>
	{
		public RemovePropertyDuplicate()
		{
			RemoveProperty(p => p.BoolProperty);
			RemoveProperty(p => p.BoolProperty);
		}
	}
}
