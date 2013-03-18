using SearchBuilder.Operators;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SearchBuilder
{
	public class Property : IProperty
	{
		public string Name { get; protected set; }
		public string DisplayName { get; protected set; }
		public List<Operator> Operators { get; protected set; }

		/// <summary>
		/// Creates a new instance of a Property with the specified <seealso cref="PropertyInfo"/>.
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

			// Default the operators for the type.
			Operators = OperatorSupport.GetSupportedOperators(propertyInfo.PropertyType);
		}

		/// <summary>
		/// Overrides the default translation of the DisplayName by providing a means of specifiying it explicitely.
		/// </summary>
		/// <param name="displayName">Name to set</param>
		/// <returns><seealso cref="IProperty"/> to continue defining the property.</returns>
		public IProperty DisplayAs(string displayName)
		{
			DisplayName = displayName;
			return this;
		}
	}
}
