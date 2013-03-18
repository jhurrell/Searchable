using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using System.Linq;

namespace SearchableTests.ConfigurationTests
{
	[TestClass]
	public class DefaultTests
	{
		protected SearchBuilder<SampleClass> target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new SearchBuilder<SampleClass>();
		}

		[TestMethod]
		public void All_Supported_Properties_Included()
		{
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
				"BoolProperty",
				"DateTimeProperty",
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
				"NullableDateTimeProperty",
				"StringProperty",
				"ObjectEnumerable",
				"ObjectArray",
			};

			var actual = target.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}
	}
}
