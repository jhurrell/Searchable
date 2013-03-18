using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class DisplayNameTests
	{
		[TestClass]
		public class Default
		{
			[TestMethod]
			public void Formatted_With_Spaces()
			{
				var target = new DisplayNameDefaultSearchBuilder();
				var property = target["SomePropertyName"];
				Assert.AreEqual("Some Property Name", property.DisplayName);
			}

			[TestMethod]
			public void Formatted_With_Acronyms()
			{
				var target = new DisplayNameDefaultSearchBuilder();
				var property = target["LOLPropertyNASA"];
				Assert.AreEqual("LOL Property NASA", property.DisplayName);
			}			
		}

		[TestClass]
		public class Explicit
		{
			[TestMethod]
			public void Accepts_Given_Override_For_DisplayName()
			{
				var target = new DisplayNameExplicitSearchBuilder();
				var property = target["LOLPropertyNASA"];
				Assert.AreEqual("NASA Property LOL", property.DisplayName);
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

	public class DisplayNameExplicitSearchBuilder : SearchBuilder<DisplayNameExplicit>
	{
		public DisplayNameExplicitSearchBuilder()
		{
			AddProperty(p => p.LOLPropertyNASA)
				.DisplayAs("NASA Property LOL");
		}
	}
}
