using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SearchBuilder.Tests.SearchBuilderTests
{
	[TestClass]
	public class CannotSearchTests
	{
		protected SearchBuilder<SampleClass> Tester = new SearchBuilder<SampleClass>();

		[TestMethod]
		public void CannotSearch_CallingTwiceForSameProperty_RaisesException()
		{
			try
			{
				Tester.CannotSearch(x => x.BoolProperty);
				Tester.CannotSearch(x => x.BoolProperty);
				Assert.Fail();
			}
			catch (Exception ex)
			{
				Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
				Assert.AreEqual("CannotSearch() has already been called for property BoolProperty.", ex.Message);
			}
		}

		[TestMethod]
		public void CannotSearch_AndCanSearch_RaisesException()
		{
			try
			{
				Tester.CannotSearch(x => x.ByteProperty);
				Tester.CanSearch(x => x.BoolProperty);
				Assert.Fail();
			}
			catch (Exception ex)
			{
				Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));
				Assert.AreEqual("Cannot mix CanSearch() and CannotSearch().", ex.Message);
			}
		}

		[TestMethod]
		public void CannotSearch_ForProperties_RemovesOnlySpecifiedPropertyFromCollection()
		{
			Tester.CannotSearch(x => x.BoolProperty);
			var actual = Tester.Properties.Select(p => p.Name).OrderBy(p => p).ToArray();

			CollectionAssert.DoesNotContain(actual, "BoolProperty");
		}

		[TestMethod]
		public void CannotSearch_OnStringPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["StringProperty"]);
			Tester.CannotSearch(x => x.StringProperty);
			Assert.IsNull(Tester["StringProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnIEnumerablePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["ObjectEnumerable"]);
			Tester.CannotSearch(x => x.ObjectEnumerable);
			Assert.IsNull(Tester["ObjectEnumerable"]);
		}

		[TestMethod]
		public void CannotSearch_OnArrayPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["ObjectArray"]);
			Tester.CannotSearch(x => x.ObjectArray);
			Assert.IsNull(Tester["ObjectArray"]);
		}

		[TestMethod]
		public void CannotSearch_OnBoolPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["BoolProperty"]);
			Tester.CannotSearch(x => x.BoolProperty);
			Assert.IsNull(Tester["BoolProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableBoolPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableBoolProperty"]);
			Tester.CannotSearch(x => x.NullableBoolProperty);
			Assert.IsNull(Tester["NullableBoolProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnBytePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["ByteProperty"]);
			Tester.CannotSearch(x => x.ByteProperty);
			Assert.IsNull(Tester["ByteProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableBytePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableByteProperty"]);
			Tester.CannotSearch(x => x.NullableByteProperty);
			Assert.IsNull(Tester["NullableByteProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnCharPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["CharProperty"]);
			Tester.CannotSearch(x => x.CharProperty);
			Assert.IsNull(Tester["CharProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableCharPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableCharProperty"]);
			Tester.CannotSearch(x => x.NullableCharProperty);
			Assert.IsNull(Tester["NullableCharProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnDecimalPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["DecimalProperty"]);
			Tester.CannotSearch(x => x.DecimalProperty);
			Assert.IsNull(Tester["DecimalProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableDecimalPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableDecimalProperty"]);
			Tester.CannotSearch(x => x.NullableDecimalProperty);
			Assert.IsNull(Tester["NullableDecimalProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnDoublePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["DoubleProperty"]);
			Tester.CannotSearch(x => x.DoubleProperty);
			Assert.IsNull(Tester["DoubleProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableDoublePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableDoubleProperty"]);
			Tester.CannotSearch(x => x.NullableDoubleProperty);
			Assert.IsNull(Tester["NullableDoubleProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnFloatPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["FloatProperty"]);
			Tester.CannotSearch(x => x.FloatProperty);
			Assert.IsNull(Tester["FloatProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableFloatPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableFloatProperty"]);
			Tester.CannotSearch(x => x.NullableFloatProperty);
			Assert.IsNull(Tester["NullableFloatProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnIntPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["IntProperty"]);
			Tester.CannotSearch(x => x.IntProperty);
			Assert.IsNull(Tester["IntProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableIntPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableIntProperty"]);
			Tester.CannotSearch(x => x.NullableIntProperty);
			Assert.IsNull(Tester["NullableIntProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnLongPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["LongProperty"]);
			Tester.CannotSearch(x => x.LongProperty);
			Assert.IsNull(Tester["LongProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableLongPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableLongProperty"]);
			Tester.CannotSearch(x => x.NullableLongProperty);
			Assert.IsNull(Tester["NullableLongProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnSbytePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["SbtyeProperty"]);
			Tester.CannotSearch(x => x.SbtyeProperty);
			Assert.IsNull(Tester["SbtyeProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableSbytePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableSbtyeProperty"]);
			Tester.CannotSearch(x => x.NullableSbtyeProperty);
			Assert.IsNull(Tester["NullableSbtyeProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnUintPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["UintProperty"]);
			Tester.CannotSearch(x => x.UintProperty);
			Assert.IsNull(Tester["UintProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableUintPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableUintProperty"]);
			Tester.CannotSearch(x => x.NullableUintProperty);
			Assert.IsNull(Tester["NullableUintProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnUlongPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["UlongProperty"]);
			Tester.CannotSearch(x => x.UlongProperty);
			Assert.IsNull(Tester["UlongProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableUlongPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableUlongProperty"]);
			Tester.CannotSearch(x => x.NullableUlongProperty);
			Assert.IsNull(Tester["NullableUlongProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnUshortPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["UshortProperty"]);
			Tester.CannotSearch(x => x.UshortProperty);
			Assert.IsNull(Tester["UshortProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableUshortPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableUshortProperty"]);
			Tester.CannotSearch(x => x.NullableUshortProperty);
			Assert.IsNull(Tester["NullableUshortProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnDateTimePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["DateTimeProperty"]);
			Tester.CannotSearch(x => x.DateTimeProperty);
			Assert.IsNull(Tester["DateTimeProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnNullableDateTimePropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["NullableDateTimeProperty"]);
			Tester.CannotSearch(x => x.NullableDateTimeProperty);
			Assert.IsNull(Tester["NullableDateTimeProperty"]);
		}

		[TestMethod]
		public void CannotSearch_OnEnumPropertyType_RemovesPropertyFromCollection()
		{
			Assert.IsNotNull(Tester["EnumProperty"]);
			Tester.CannotSearch(x => x.EnumProperty);
			Assert.IsNull(Tester["EnumProperty"]);
		}
	}
}
