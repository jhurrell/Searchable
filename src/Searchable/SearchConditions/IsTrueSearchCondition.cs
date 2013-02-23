using System.Reflection;

namespace Searchable.SearchConditions
{
	public class IsTrueSearchCondition : SearchConditionBase
	{
		public IsTrueSearchCondition(PropertyInfo propertyInfo) : base(propertyInfo)
		{
			this.Initialize();
		}

		public IsTrueSearchCondition(PropertyInfo propertyInfo, string displayName) : base(propertyInfo, displayName)
		{
			this.Initialize();
		}

		private void Initialize()
		{
			MinimumRequiredValues = 0;
			MaximumRequiredValues = 0;
		}
	}
}
