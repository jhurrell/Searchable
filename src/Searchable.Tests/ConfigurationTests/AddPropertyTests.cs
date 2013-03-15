using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using System;
using System.Linq;

namespace SearchableTests.ConfigurationTests
{
	[TestClass]
	public class AddPropertyTests
	{
		[TestMethod]
		public void Resets_Collection()
		{
			var target = new AddPropertySingle();
			Assert.AreEqual(1, target.Properties.Count);
		}

		[TestMethod]
		public void Adds_Property_To_Collection()
		{
			var target = new AddPropertySingle();
			var expected = new string[] { "BoolProperty" };
			var actual = target.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);			
		}

		[TestMethod]
		public void Does_Not_Reset_Additional_Properties()
		{
			var target = new AddPropertyMultiple();
			var expected = new string[] { "BoolProperty", "UshortProperty" };
			var actual = target.Properties.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Can_Only_Add_Property_Once()
		{
			var target = new AddPropertyDuplicate();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Cannot_Add_Unsupported()
		{
			var target = new AddPropertyUnsupported();
		}
	}

	public class AddPropertySingle : SearchBuilder<SampleClass>
	{
		public AddPropertySingle()
		{
			AddProperty(p => p.BoolProperty);
		}
	}

	public class AddPropertyMultiple : SearchBuilder<SampleClass>
	{
		public AddPropertyMultiple()
		{
			AddProperty(p => p.BoolProperty);
			AddProperty(p => p.UshortProperty);
		}
	}

	public class AddPropertyDuplicate : SearchBuilder<SampleClass>
	{
		public AddPropertyDuplicate()
		{
			AddProperty(p => p.BoolProperty);
			AddProperty(p => p.BoolProperty);
		}
	}

	public class AddPropertyUnsupported : SearchBuilder<SampleClass>
	{
		public AddPropertyUnsupported()
		{
			AddProperty(p => p.Component);
		}
	}
}
