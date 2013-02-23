using System.Reflection;

namespace Searchable
{
	public class Condition
	{
		public PropertyInfo PropertyInfo { get; private set; }
		public string DisplayName { get; private set; }

		/// <summary>
		/// Instantiate an instance of Condition with PropertyInfo and a display name equal to
		/// the property name.
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo describing property to search.</param>
		public Condition(PropertyInfo propertyInfo)
		{
			PropertyInfo = propertyInfo;
			DisplayName = propertyInfo.Name;
		}

		/// <summary>
		/// Instantiate an instance of Condition with PropertyInfo and a custom display name.
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo describing property to search.</param>
		/// <param name="displayName">Name to display for the property.</param>
		public Condition(PropertyInfo propertyInfo, string displayName)
		{
			PropertyInfo = propertyInfo;
			DisplayName = displayName;
		}
	}
}
