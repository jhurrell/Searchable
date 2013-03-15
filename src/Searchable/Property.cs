using System.Linq;
using System.Reflection;

namespace SearchBuilder
{
	public class Property
	{
		public string Name { get; protected set; }
		public string DisplayName { get; protected set; }

		/// <summary>
		/// 
		/// </summary>
		public Property(PropertyInfo propertyInfo)
		{
			Name = propertyInfo.Name;

			// Shamelessly copied from http://stackoverflow.com/questions/9964467/create-space-between-capital-letters-and-skip-space-between-consecutive
			DisplayName = string.Join
				(
					string.Empty, 
					Name.Select((x, i) => (char.IsUpper(x) && i > 0 && (char.IsLower(Name[i - 1]) || (i < Name.Count() - 1 && char.IsLower(Name[i + 1])))) ? " " + x : x.ToString())
				);
		}
	}
}
