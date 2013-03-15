using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class NameTests
	{
		[TestMethod]
		public void Set_From_Property_Name()
		{
			var target = new NameSampleSearchBuilder();
			var property = target["SomeProperty"];
			Assert.AreEqual("SomeProperty", property.Name);			
		}
	}

	public class NameSample
	{
		public string SomeProperty { get; set; }
	}

	public class NameSampleSearchBuilder : SearchBuilder<NameSample>
	{
	}
}
