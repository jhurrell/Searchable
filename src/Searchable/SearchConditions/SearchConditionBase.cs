using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reflection;
using System;

namespace Searchable.SearchConditions
{
	public abstract class SearchConditionBase
	{
		public virtual ObservableCollection<object> Values { get; set; }
		public virtual PropertyInfo PropertyInfo { get; protected set; }
		public virtual string DisplayName { get; protected set; }
		public int MinimumRequiredValues { get; protected set; }
		public int MaximumRequiredValues { get; protected set; }

		/// <summary>
		/// Initializes a new version of the SearchConditionBase class that contains the <seealso cref="PropertyInfo"/> 
		/// and DisplayName read from the property.
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo describing property to search.</param>
		public SearchConditionBase(PropertyInfo propertyInfo) : this(propertyInfo, propertyInfo.Name)
		{
		}

		/// <summary>
		/// Initializes a new version of the SearchConditionBase class that contains the <seealso cref="PropertyInfo"/> and DisplayName specified.
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo describing property to search.</param>
		/// <param name="displayName">Name to display for the property.</param>
		public SearchConditionBase(PropertyInfo propertyInfo, string displayName)
		{
			PropertyInfo = propertyInfo;
			DisplayName = displayName;

			// Set the number of values here to enforce explicitely setting them in the concrete
			// instances.
			MinimumRequiredValues = int.MinValue;
			MaximumRequiredValues = int.MinValue;

			// Define the handler for receiving events when the Values collection is changed.
			Values = new ObservableCollection<object>();
			Values.CollectionChanged += ValuesChanged;
		}

		/// <summary>
		/// Executes when the Values collection is modified.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void ValuesChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			throw new NotImplementedException("");
		}
	}
}
