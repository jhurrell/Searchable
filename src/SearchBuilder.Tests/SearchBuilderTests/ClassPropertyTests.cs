using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.PropertyBuilders;

namespace SearchBuilder.Tests.SearchBuilderTests
{
	[TestClass]
	public class ClassPropertyTests
	{
		[TestClass]
		public class PropertiesCollectionTests
		{
			[TestMethod]
			public void PropertiesCollection_OnInstantiation_IsInitialized()
			{
				var builder = new SearchBuilder<SampleClass>();
				Assert.IsNotNull(builder.Properties);
			}

			[TestMethod]
			public void PropertiesCollection_OnInstantiation_IncludesAllProperties()
			{
				var expected = new[] 
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
					"EnumProperty",
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

				var builder = new SearchBuilder<SampleClass>();
				var actual = builder.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

				CollectionAssert.AreEquivalent(expected, actual);
			}
		}

		[TestClass]
		public class PropertiesIndexerTests
		{
			protected PropertyBuilderBase target { get; set; }

			[TestInitialize]
			public void TestInitialize()
			{
				var builder = new SearchBuilder<SampleClass>();
				target = builder["StringProperty"];
			}

			[TestMethod]
			public void PropertiesIndexer_WhenExists_ReturnsOperator()
			{
				var op = target["BeginsWith"];
				Assert.AreEqual("BeginsWith", op.Name);
			}

			[TestMethod]
			public void PropertiesIndexer_WhenDoesNotExist_ReturnsNull()
			{
				var op = target["DoesNotExist"];
				Assert.IsNull(op);
			}
		}
	}
}
