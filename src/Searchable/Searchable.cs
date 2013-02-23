using System.Reflection;

namespace Searchable
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Searchable<T>
    {
		/// <summary>
		/// 
		/// </summary>
		public Searchable()
		{
			// Enuerate all the properties and determine which can be added to the collection of those
			// we will support with searching.
			PropertyInfo[] propertyInfos;
			propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

		}
    }
}
