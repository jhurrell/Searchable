using SearchBuilder.Operators;
using SearchBuilder.PropertyBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using SearchBuilder.PropertyBuilders.Collection;
using SearchBuilder.PropertyBuilders.Enum;
using SearchBuilder.PropertyBuilders.Numeric;
using SearchBuilder.PropertyBuilders.String;

namespace SearchBuilder
{
	/// <summary>
	/// Provides methods for collecting and building search criteria for a class.
	/// </summary>
	/// <typeparam name="T">Type of object for building search criteria.</typeparam>
	public class SearchBuilder<T>
	{
		public List<PropertyBuilderBase> Properties { get; private set; }
        public List<PropertyBuilderBase> Conditions { get; private set; }
        private PropertiesDefinedBy PropertiesDefinedBy { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SearchBuilder()
		{
			Properties = new List<PropertyBuilderBase>();
            Conditions = new List<PropertyBuilderBase>();
            PropertiesDefinedBy = PropertiesDefinedBy.Default;

			// Add supported properties to the collection.
			var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (var propertyInfo in propertyInfos.Where(propertyInfo => OperatorSupport.IsTypeSupported(propertyInfo.PropertyType)))
			{
				Properties.Add(new PropertyBuilderBase(propertyInfo));
			}
		}

        /// <summary>
        /// Indexer for searchable <seealso cref="PropertyBuilderBase"/>
        /// </summary>
        /// <param name="name">Name of the property.</param>
        /// <returns>Property with the specified name.</returns>
        public PropertyBuilderBase this[string name]
        {
            get
            {
                return Properties.FirstOrDefault(p => p.Name == name);
            }
        }

        /// <summary>
        /// Extractes PropertyInfo specified by the expression.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="propertyLambda"></param>
        /// <returns><see cref="PropertyInfo"/>PropertyInfo for the type described by the expression.</returns>
        private static PropertyInfo GetPropertyInfo<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
		{
			PropertyInfo propertyInfo = null;

			// Retrieve the member expression for the property lamda. This will work for reference and value types.
			var member = propertyLambda.Body as MemberExpression ?? ((UnaryExpression)propertyLambda.Body).Operand as MemberExpression;
			if (member != null)
			{
				propertyInfo = member.Member as PropertyInfo;
			}

			return propertyInfo;
		}

		#region CanSearch

		/// <summary>
		/// Called when CanSearch(expresison) methods are called to switch the means by which
		/// supported properties are specified.
		/// </summary>
		/// <exception cref="InvalidOperationException">The exception that is thrown when CanSearch() and CannotSearch() are both called when defining a SearchBuilder.</exception>
		private void ChangeToCanSearch()
		{
			// Make sure we're not mixing CanSearch() and CannotSearch().
			if (PropertiesDefinedBy == PropertiesDefinedBy.CannotSearch)
				throw new InvalidOperationException("Cannot mix CanSearch() and CannotSearch().");

			// Change the method by which we identify searchable properties.
			if (PropertiesDefinedBy == PropertiesDefinedBy.CanSearch) return;
			PropertiesDefinedBy = PropertiesDefinedBy.CanSearch;
			Properties.Clear();
		}

		/// <summary>
		/// Common function to test whether the property name specified already exists in the collection of supported properties.
		/// </summary>
		/// <param name="propertyName">Name of property to test.</param>
		/// <exception cref="InvalidOperationException">The exception that is thrown when the property already exists in the supported properties collection</exception>
		private void TestCanSearchProperty(string propertyName)
		{
			// Detmerine if the property has already been specified by CanSearch().
			if (Properties.Exists(p => p.Name == propertyName))
				throw new InvalidOperationException(string.Format("CanSearch() has already been called for property '{0}'.", propertyName));
		}

		/// <summary>
		/// Common function for handing the CanSearch logic for numeric types.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="propertyLambda"></param>
		/// <returns><seealso cref="NumericPropertyBuilder"/> for the property.</returns>
		private NumericPropertyBuilder CanSearchNumericProperty<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
		{
			// Flip the PropertiesDefinedBy from Default to CanSearch.
			ChangeToCanSearch();

			// Retrieve the Property object for the member specified.
			var propertyInfo = GetPropertyInfo(propertyLambda);
			var property = new NumericPropertyBuilder(propertyInfo);

			// Detmerine if the property has already been specified by CanSearch().
			TestCanSearchProperty(property.Name);

			// Add to the collection.
			Properties.Add(property);

			return property;
		}

		/// <summary>
		/// Creates a property definition for strings types.
		/// </summary>
		/// <param name="expression">Expression identifying a property.</param>
		/// <returns><seealso cref="StringPropertyBuilder"/>StringProperty</returns>
		public IStringPropertyBuilder CanSearch(Expression<Func<T, string>> expression)
		{
			ChangeToCanSearch();

			// Retrieve the Property object for the member specified.
			var propertyInfo = GetPropertyInfo(expression);
			var property = new StringPropertyBuilder(propertyInfo);

			// Detmerine if the property has already been specified by CanSearch().
			TestCanSearchProperty(property.Name);

			// Add to the collection.
			Properties.Add(property);

			return property;
		}

		/// <summary>
		/// Creates a property definition for collection types.
		/// </summary>
		/// <param name="expression">Expression identifying a collection property.</param>
		/// <returns><seealso cref="CollectionPropertyBuilder"/>NumericProperty</returns>
		public ICollectionPropertyBuilder CanSearch(Expression<Func<T, IEnumerable<object>>> expression)
		{
			ChangeToCanSearch();

			// Retrieve the Property object for the member specified.
			var propertyInfo = GetPropertyInfo(expression);
			var property = new CollectionPropertyBuilder(propertyInfo);

			// Detmerine if the property has already been specified by CanSearch().
			TestCanSearchProperty(property.Name);

			// Add to the collection.
			Properties.Add(property);

			return property;
		}

		/// <summary>
		/// Creates a property definition for Enum types.
		/// </summary>
		/// <param name="expression">Expression identifying an Enum property.</param>
		/// <returns><seealso cref="EnumPropertyBuilder"/>EnumProperty</returns>
		public IEnumPropertyBuilder CanSearch(Expression<Func<T, Enum>> expression)
		{
			ChangeToCanSearch();

			// Retrieve the Property object for the member specified.
			var propertyInfo = GetPropertyInfo(expression);
			var property = new EnumPropertyBuilder(propertyInfo);

			// Detmerine if the property has already been specified by CanSearch().
			TestCanSearchProperty(property.Name);

			// Add to the collection.
			Properties.Add(property);

			return property;
		}

		/// <summary>
		/// Creates a property definition for byte types.
		/// </summary>
		/// <param name="expression">Expression identifying a byte property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, byte>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable byte types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable byte property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, byte?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for bool types.
		/// </summary>
		/// <param name="expression">Expression identifying a bool property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, bool>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable bool types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable bool property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, bool?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for char types.
		/// </summary>
		/// <param name="expression">Expression identifying a char property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, char>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable char types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable char property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, char?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for decimal types.
		/// </summary>
		/// <param name="expression">Expression identifying a decimal property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, decimal>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable decimal types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable decimal property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, decimal?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for double types.
		/// </summary>
		/// <param name="expression">Expression identifying a double property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, double>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable double types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable double property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, double?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for float types.
		/// </summary>
		/// <param name="expression">Expression identifying a float property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, float>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable float types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable float property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public NumericPropertyBuilder CanSearch(Expression<Func<T, float?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for int types.
		/// </summary>
		/// <param name="expression">Expression identifying a int property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, int>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable int types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable int property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, int?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for long types.
		/// </summary>
		/// <param name="expression">Expression identifying a long property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public NumericPropertyBuilder CanSearch(Expression<Func<T, long>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable long types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable long property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, long?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for sbyte types.
		/// </summary>
		/// <param name="expression">Expression identifying a sbyte property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, sbyte>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable sbyte types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable sbyte property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, sbyte?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for uint types.
		/// </summary>
		/// <param name="expression">Expression identifying a uint property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, uint>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable uint types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable uint property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, uint?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for ulong types.
		/// </summary>
		/// <param name="expression">Expression identifying a ulong property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, ulong>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable ulong types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable ulong property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, ulong?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for ushort types.
		/// </summary>
		/// <param name="expression">Expression identifying a ushort property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, ushort>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable ushort types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable ushort property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, ushort?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for DateTime types.
		/// </summary>
		/// <param name="expression">Expression identifying a DateTime property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, DateTime>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		/// <summary>
		/// Creates a property definition for nullable DateTime types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable DateTime property.</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/>NumericProperty</returns>
		public INumericPropertyBuilder CanSearch(Expression<Func<T, DateTime?>> expression)
		{
			return CanSearchNumericProperty(expression);
		}

		#endregion

		#region CannotSearch

		/// <summary>
		/// Called when CannotSearch(expresison) methods are called to switch the means by which
		/// supported properties are specified.
		/// </summary>
		public void ChangeToCannotSearch()
		{
			// Make sure we're not mixing CanSearch() and CannotSearch().
			if (PropertiesDefinedBy == PropertiesDefinedBy.CanSearch)
				throw new InvalidOperationException("Cannot mix CanSearch() and CannotSearch().");

			// Change the method by which we identify searchable properties.
			PropertiesDefinedBy = PropertiesDefinedBy.CannotSearch;
		}

		/// <summary>
		/// Common function for handing the CanSearch logic for numeric types.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="propertyLambda"></param>
		private void CannotSearchProperty<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
		{
			// Flip the PropertiesDefinedBy from Default to CanSearch.
			ChangeToCannotSearch();

			// Retrieve the Property object for the member specified.
			var propertyInfo = GetPropertyInfo(propertyLambda);

			// Detmerine if the property has already been specified by CannotSearch().
			if (!Properties.Exists(p => p.Name == propertyInfo.Name))
				throw new InvalidOperationException(string.Format("CannotSearch() has already been called for property {0}.", propertyInfo.Name));

			// Remove the property from the collection.
			var property = this[propertyInfo.Name];
			Properties.Remove(property);
		}

		/// <summary>
		/// Removes a property definition for string types.
		/// </summary>
		/// <param name="expression">Expression identifying a string property.</param>
		public void CannotSearch(Expression<Func<T, string>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for IEnumerable types.
		/// </summary>
		/// <param name="expression">Expression identifying an IEnumerable property.</param>
		public void CannotSearch(Expression<Func<T, IEnumerable<object>>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for bool types.
		/// </summary>
		/// <param name="expression">Expression identifying a bool property.</param>
		public void CannotSearch(Expression<Func<T, bool>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable bool types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable bool property.</param>
		public void CannotSearch(Expression<Func<T, bool?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for byte types.
		/// </summary>
		/// <param name="expression">Expression identifying a byte property.</param>
		public void CannotSearch(Expression<Func<T, byte>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable byte types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable byte property.</param>
		public void CannotSearch(Expression<Func<T, byte?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for char types.
		/// </summary>
		/// <param name="expression">Expression identifying a char property.</param>
		public void CannotSearch(Expression<Func<T, char>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable char types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable char property.</param>
		public void CannotSearch(Expression<Func<T, char?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for decimal types.
		/// </summary>
		/// <param name="expression">Expression identifying a decimal property.</param>
		public void CannotSearch(Expression<Func<T, decimal>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable decimal types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable decimal property.</param>
		public void CannotSearch(Expression<Func<T, decimal?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for double types.
		/// </summary>
		/// <param name="expression">Expression identifying a double property.</param>
		public void CannotSearch(Expression<Func<T, double>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable double types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable double property.</param>
		public void CannotSearch(Expression<Func<T, double?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for float types.
		/// </summary>
		/// <param name="expression">Expression identifying a float property.</param>
		public void CannotSearch(Expression<Func<T, float>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable float types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable float property.</param>
		public void CannotSearch(Expression<Func<T, float?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for int types.
		/// </summary>
		/// <param name="expression">Expression identifying a int property.</param>
		public void CannotSearch(Expression<Func<T, int>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable int types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable int property.</param>
		public void CannotSearch(Expression<Func<T, int?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for long types.
		/// </summary>
		/// <param name="expression">Expression identifying a long property.</param>
		public void CannotSearch(Expression<Func<T, long>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable long types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable long property.</param>
		public void CannotSearch(Expression<Func<T, long?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for sbyte types.
		/// </summary>
		/// <param name="expression">Expression identifying a sbyte property.</param>
		public void CannotSearch(Expression<Func<T, sbyte>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable sbyte types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable sbyte property.</param>
		public void CannotSearch(Expression<Func<T, sbyte?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for uint types.
		/// </summary>
		/// <param name="expression">Expression identifying a uint property.</param>
		public void CannotSearch(Expression<Func<T, uint>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable uint types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable uint property.</param>
		public void CannotSearch(Expression<Func<T, uint?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for ulong types.
		/// </summary>
		/// <param name="expression">Expression identifying a ulong property.</param>
		public void CannotSearch(Expression<Func<T, ulong>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable ulong types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable ulong property.</param>
		public void CannotSearch(Expression<Func<T, ulong?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for ushort types.
		/// </summary>
		/// <param name="expression">Expression identifying a ushort property.</param>
		public void CannotSearch(Expression<Func<T, ushort>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable ushort types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable ushort property.</param>
		public void CannotSearch(Expression<Func<T, ushort?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for DateTime types.
		/// </summary>
		/// <param name="expression">Expression identifying a DateTime property.</param>
		public void CannotSearch(Expression<Func<T, DateTime>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Nullable DateTime types.
		/// </summary>
		/// <param name="expression">Expression identifying a Nullable DateTime property.</param>
		public void CannotSearch(Expression<Func<T, DateTime?>> expression)
		{
			CannotSearchProperty(expression);
		}

		/// <summary>
		/// Removes a property definition for Enum types.
		/// </summary>
		/// <param name="expression">Expression identifying an Enum property.</param>
		public void CannotSearch(Expression<Func<T, Enum>> expression)
		{
			CannotSearchProperty(expression);
		}

		#endregion
	}
}
