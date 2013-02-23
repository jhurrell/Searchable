using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable.SearchConditions;
using System.Reflection;

namespace SearchableTests.SearchConditions
{
	[TestClass]
	public class IsTrueSearchConditionTests : SearchConditionsTestBase<IsTrueSearchCondition>
	{
		[TestClass]
		public class MinimumRequiredValuesTests : IsTrueSearchConditionTests
		{
			[TestMethod]
			public void Is_Zero()
			{
				Condition = new IsTrueSearchCondition(PropertyInfos[0], "");
				Assert.AreEqual(0, Condition.MinimumRequiredValues);
			}
		}

		[TestClass]
		public class MaximumRequiredValuesTests : IsTrueSearchConditionTests
		{
			[TestMethod]
			public void Is_Zero()
			{
				Condition = new IsTrueSearchCondition(PropertyInfos[0], "");
				Assert.AreEqual(0, Condition.MaximumRequiredValues);
			}
		}
	}
}
