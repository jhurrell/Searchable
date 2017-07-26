using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SearchBuilder.PropertyBuilders.Collection;
using SearchBuilder.PropertyBuilders.Enum;
using SearchBuilder.PropertyBuilders.Numeric;
using SearchBuilder.PropertyBuilders.String;

namespace SearchBuilder.Tests.SearchBuilderTests
{
	[TestClass]
	public class CanSearchTests
	{
		protected SearchBuilder<SampleClass> Tester = new SearchBuilder<SampleClass>();

		[TestMethod]
		public void CanSearch_CallingTwiceForSameProperty_RaisesException()
		{
			try
			{
				Tester.CanSearch(x => x.BoolProperty);
				Tester.CanSearch(x => x.BoolProperty);
				Assert.Fail();
			}
			catch(Exception ex)
			{
				Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
				Assert.AreEqual("CanSearch() has already been called for property 'BoolProperty'.", ex.Message);
			}
		}

		[TestMethod]
		public void CanSearch_AndCannotSearch_RaisesException()
		{
			try
			{
				Tester.CanSearch(x => x.BoolProperty);
				Tester.CannotSearch(x => x.ByteProperty);
				Assert.Fail();
			}
			catch(Exception ex)
			{
				Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
				Assert.AreEqual("Cannot mix CanSearch() and CannotSearch().", ex.Message);
			}
		}

		[TestMethod]
		public void CanSearch_CallingOnce_ResetsPropertiesCollection()
		{
			var countBefore = Tester.Properties.Count;
			Tester.CanSearch(x => x.BoolProperty);
			var countAfter = Tester.Properties.Count;

			Assert.AreEqual(32, countBefore);
			Assert.AreEqual(1, countAfter);
		}

		[TestMethod]
		public void CanSearch_ForProperties_IncludesOnlyThosePropertiesInPropertiesCollection()
		{
			string[] expected = { "BoolProperty", "IntProperty", "LongProperty" };

			Tester.CanSearch(x => x.BoolProperty);
			Tester.CanSearch(x => x.IntProperty);
			Tester.CanSearch(x => x.LongProperty);
			var actual = Tester.Properties.Select(p => p.Name).OrderBy(p => p).ToArray();

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CanSearch_OnStringPropertyType_ReturnsStringProperty()
		{
			var result = Tester.CanSearch(x => x.StringProperty);
			Assert.IsInstanceOfType(result, typeof(StringPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnIEnumerablePropertyType_ReturnsCollectionProperty()
		{
			var result = Tester.CanSearch(x => x.ObjectEnumerable);
			Assert.IsInstanceOfType(result, typeof(CollectionPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnArrayPropertyType_ReturnsCollectionProperty()
		{
			var result = Tester.CanSearch(x => x.ObjectArray);
			Assert.IsInstanceOfType(result, typeof(CollectionPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnBoolPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.BoolProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableBoolPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableBoolProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnBytePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.ByteProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableBytePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableByteProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnCharPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.CharProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableCharPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableCharProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnDecimalPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.DecimalProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableDecimalPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableDecimalProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnDoublePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.DoubleProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableDoublePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableDoubleProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnFloatPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.FloatProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableFloatPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableFloatProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnIntPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.IntProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableIntPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableIntProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnLongPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.LongProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableLongPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableLongProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnSbytePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.SbtyeProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableSbytePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableSbtyeProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnUintPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.UintProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableUintPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableUintProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnUlongPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.UlongProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableUlongPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableUlongProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnUshortPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.UshortProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableUshortPropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableUshortProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnDateTimePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.DateTimeProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnNullableDateTimePropertyType_ReturnsNumericProperty()
		{
			var result = Tester.CanSearch(x => x.NullableDateTimeProperty);
			Assert.IsInstanceOfType(result, typeof(NumericPropertyBuilder));
		}

		[TestMethod]
		public void CanSearch_OnEnumPropertyType_ReturnsEnumProperty()
		{
			var result = Tester.CanSearch(x => x.EnumProperty);
			Assert.IsInstanceOfType(result, typeof(EnumPropertyBuilder));
		}
	}
}
