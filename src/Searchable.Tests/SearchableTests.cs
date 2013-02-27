using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

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
	}
}
