using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests
{
	[TestClass]
	public class SearchableTests
	{
		protected SearchBuilder<SampleClass> target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new SearchBuilder<SampleClass>();
		}

		[TestClass]
		public class IndexerTests : SearchableTests
		{
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
}
