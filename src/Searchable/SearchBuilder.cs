using SearchBuilder.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SearchBuilder
{
	/// <summary>
	/// Provides methods for collecting and building search criteria for a class.
	/// </summary>
	/// <typeparam name="T">Type of object for building search criteria.</typeparam>
	public class SearchBuilder<T>
	{
		public List<Property> Properties { get; private set; }
		private PropertiesDefinedBy PropertiesDefinedBy { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SearchBuilder()
		{
			Properties = new List<Property>();
			PropertiesDefinedBy = PropertiesDefinedBy.Default;

			// Add supported properties to the collection.
			var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (var propertyInfo in propertyInfos)
			{
				if (OperatorSupport.IsTypeSupported(propertyInfo.PropertyType))
					Properties.Add(new Property(propertyInfo));
			}
		}

		/// <summary>
		/// Adds a <seealso cref="Property"/> to the collection of searchable properties.
		/// </summary>
		/// <param name="expression">Expression identifying the property.</param>
		/// <returns><seealso cref="Property"/> added to the collection.</returns>
		protected IProperty AddProperty(Expression<Func<T, object>> expression)
		{
			// Change the method by which we identify searchable properties.
			if (PropertiesDefinedBy != PropertiesDefinedBy.AddProperty)
			{
				PropertiesDefinedBy = PropertiesDefinedBy.AddProperty;
				Properties.Clear();
			}

			// Retrieve the propertyInfo for the member specified.
			var propertyInfo = GetPropertyInfo(typeof(T), expression);

			// Verify the type is supported.
			if (!OperatorSupport.IsTypeSupported(propertyInfo.PropertyType))
				throw new ArgumentException(string.Format("AddProperty cannot be called for unsupported member {0}.", propertyInfo.Name));

			// Verify the property has not already been added.
			if (Properties.Any(p => p.Name == propertyInfo.Name))
				throw new ArgumentException(string.Format("AddProperty already called for member {0}.", propertyInfo.Name));

			// Add to the collection.
			var property = new Property(propertyInfo);
			Properties.Add(property);

			return property;
		}

		/// <summary>
		/// Removes a <seealso cref="Property"/> from the collection of searchable properties.
		/// </summary>
		/// <param name="expression">Expression identifying the property.</param>
		protected void RemoveProperty(Expression<Func<T, object>> expression)
		{
			// Change the method by which we identify searchable properties.
			if (PropertiesDefinedBy != PropertiesDefinedBy.RemoveProperty)
			{
				PropertiesDefinedBy = PropertiesDefinedBy.RemoveProperty;
			}

			// Retrieve the propertyInfo for the member specified.
			var propertyInfo = GetPropertyInfo(typeof(T), expression);

			// Make sure the property has not already been added.
			if (!Properties.Any(p => p.Name == propertyInfo.Name))
				throw new ArgumentException(string.Format("RemoveProperty already called for member {0}.", propertyInfo.Name));

			// Remove from the collection.
			var property = Properties.Where(p => p.Name == propertyInfo.Name).FirstOrDefault();
			Properties.Remove(property);
		}

		/// <summary>
		/// Indexer for searchable <seealso cref="Property"/>
		/// </summary>
		/// <param name="name">Name of the property.</param>
		/// <returns>Property with the specified name.</returns>
		public Property this[string name]
		{
			get
			{
				return Properties.Where(p => p.Name == name).FirstOrDefault();
			}
		}

		private PropertyInfo GetPropertyInfo<TSource, TProperty>(Type type, Expression<Func<TSource, TProperty>> propertyLambda)
		{
			// Retrieve the member expression for the property lamda. This will work for reference and value types.
			MemberExpression member;
			try
			{
				member = propertyLambda.Body as MemberExpression ?? ((UnaryExpression)propertyLambda.Body).Operand as MemberExpression;
			}
			catch
			{
				throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.", propertyLambda.ToString()));
			}

			PropertyInfo propertyInfo = member.Member as PropertyInfo;
			if (propertyInfo == null)
				throw new ArgumentException(string.Format("Expression '{0}' refers to a field, not a property.", propertyLambda.ToString()));

			if (type != propertyInfo.ReflectedType && !type.IsSubclassOf(propertyInfo.ReflectedType))
				throw new ArgumentException(string.Format("Expresion '{0}' refers to a property that is not from type {1}.", propertyLambda.ToString(),
					type));

			return propertyInfo;
		}
	}
}
