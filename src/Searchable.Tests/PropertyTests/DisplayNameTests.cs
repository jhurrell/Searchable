using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class DisplayNameTests
	{
		[TestMethod]
		public void Formatted_With_Spaces()
		{
			var target = new DisplayNameSampleSearchBuilder();
			var property = target["SomePropertyName"];
			Assert.AreEqual("Some Property Name", property.DisplayName);
		}

		[TestMethod]
		public void Formatted_With_Acronyms()
		{
			var target = new DisplayNameSampleSearchBuilder();
			var property = target["LOLPropertyNASA"];
			Assert.AreEqual("LOL Property NASA", property.DisplayName);
		}
	}

	public class DisplayNameSample
	{
		public string SomePropertyName { get; set; }
		public string LOLPropertyNASA { get; set; }
	}

	public class DisplayNameSampleSearchBuilder : SearchBuilder<DisplayNameSample>
	{
	}
}
