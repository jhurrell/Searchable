using System.Collections.Generic;
namespace SearchBuilder
{
	/// <summary>
	/// Initializes a new SearchBuilder class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class SearchBuilder<T>
    {
		public List<Property> Properties { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public SearchBuilder()
		{
		}
    }
}
