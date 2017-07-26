using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchBuilder.Tests.PropertyBuilderTests
{
	[TestClass]
	public class DisplayNameTests
	{
		[TestClass]
		public class Default
		{
			[TestMethod]
			public void DisplayName_WhenPascalCase_ReturnsWithSpaces()
			{
				var target = new DisplayNameDefaultSearchBuilder();
				var property = target["SomePropertyName"];
				Assert.AreEqual("Some Property Name", property.DisplayName);
			}

			[TestMethod]
			public void DisplayName_Acronyms_ReturnsWithSpacesAtAcronyms()
			{
				var target = new DisplayNameDefaultSearchBuilder();
				var property = target["LOLPropertyNASA"];
				Assert.AreEqual("LOL Property NASA", property.DisplayName);
			}
		}
	}

	public class DisplayNameDefault
	{
		public string SomePropertyName { get; set; }
		public string LOLPropertyNASA { get; set; }
	}

	public class DisplayNameDefaultSearchBuilder : SearchBuilder<DisplayNameDefault>
	{
	}

	public class DisplayNameExplicit
	{
		public string SomePropertyName { get; set; }
		public string LOLPropertyNASA { get; set; }
	}
}
