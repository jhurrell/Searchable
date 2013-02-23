using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.SearchConditions;
using System.Reflection;

namespace SearchableTests.SearchConditions
{
	[TestClass]
	public class SearchConditionsTestBase<T> where T: SearchConditionBase
	{
		protected T Condition { get; set; }
		protected PropertyInfo[] PropertyInfos { get; set; }

		public SearchConditionsTestBase()
		{
			PropertyInfos = typeof(SampleClass).GetProperties(BindingFlags.Public | BindingFlags.Instance);
		}
	}
}
