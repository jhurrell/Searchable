using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace SearchableTests
{
	[TestClass]
	public class SearchableTests
	{
		protected Searchable<SampleClass> target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			target = new Searchable<SampleClass>();
		}

		[TestClass]
		public class PropertiesTests : SearchableTests
		{
			[TestMethod]
			public void Not_Null()
			{
				Assert.IsNotNull(target.Properties);
			}

			[TestMethod]
			public void Type_Is_ReadOnlyDictionary()
			{
				Assert.IsInstanceOfType(target.Properties, typeof(ReadOnlyDictionary<string, string>));
			}

			[TestMethod]
			public void Getter_Is_Public()
			{
				var propertyInfo = typeof(Searchable<>)
					.GetProperties()
					.Where(p => p.Name == "Properties")
					.First();

				Assert.IsTrue(propertyInfo.GetMethod.IsPublic);
			}
		}

		[TestClass]
		public class PropertiesDefaultTests : SearchableTests
		{
			[TestMethod]
			public void Contains_All_Properties()
			{
				var propertyInfos = typeof(SampleClass).GetProperties(BindingFlags.Public | BindingFlags.Instance);
				var names = propertyInfos.Select(x => x.Name).ToList();
				CollectionAssert.AreEquivalent(names, target.Properties.Keys);
			}			
		}
	}
}
