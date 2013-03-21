using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.SearchableTests
{
	[TestClass]
	public class IndexerTests
	{
		protected SearchBuilder<SampleClass> target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new SearchBuilder<SampleClass>();
		}

		[TestMethod]
		public void Returns_Property_When_Exists()
		{
			var property = target["StringProperty"];
			Assert.IsNotNull(property);
		}

		[TestMethod]
		public void Returns_Null_When_Not_Exists()
		{
			var property = target["DoesNotExist"];
			Assert.IsNull(property);
		}

		[TestMethod]
		public void Returns_Correct_Property()
		{
			var property = target["StringProperty"];
			Assert.AreEqual("StringProperty", property.Name);
		}
	}
}
