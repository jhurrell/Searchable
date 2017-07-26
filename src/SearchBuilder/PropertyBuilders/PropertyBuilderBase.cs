using SearchBuilder.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SearchBuilder.PropertyBuilders
{
	/// <summary>
	/// Base class for property builders.
	/// </summary>
	public class PropertyBuilderBase
	{
		public string Name { get; protected set; }
		public string DisplayName { get; protected set; }
		public List<OperatorBase> Operators { get; protected set; }
		protected PropertyInfo PropertyInfo { get; set; }
		protected OperatorsDefinedBy OperatorsDefinedBy { get; set; }

		/// <summary>
		/// Creates a new instance of a PropertyBuilder with the specified <seealso cref="PropertyInfo"/>.
		/// </summary>
		public PropertyBuilderBase(PropertyInfo propertyInfo)
		{
			Name = propertyInfo.Name;
			PropertyInfo = propertyInfo;

			// Default the name of the property.
			DisplayName = string.Join
				(
					string.Empty,
					Name.Select((x, i) => (char.IsUpper(x) && i > 0 && (char.IsLower(Name[i - 1]) || (i < Name.Count() - 1 && char.IsLower(Name[i + 1])))) ? " " + x : x.ToString())
				);

			// Default the operators for the type.
			OperatorsDefinedBy = OperatorsDefinedBy.Default;
			Operators = OperatorSupport.GetSupportedOperators(propertyInfo.PropertyType);
		}

		/// <summary>
		/// Indexer exposing the names of operators which can be applied to this property.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public OperatorBase this[string name]
		{
			get
			{
				return Operators.FirstOrDefault(o => o.Name == name);
			}
		}

		/// <summary>
		/// Returns true if all <seealso cref="OperatorBase"/> are valid.
		/// </summary>
		public bool IsValid
		{
			get
			{
				return Operators.All(o => o.IsValid);
			}
		}

		/// <summary>
		/// Includes an operator in the list of supported operators.
		/// </summary>
		/// <param name="theOperator"><seealso cref="OperatorBase"/> consider for inclusion.</param>
		protected void Include(OperatorBase theOperator)
		{
			// Determine if we are moving from Default or Exclude. 
			switch (OperatorsDefinedBy)
			{
				case OperatorsDefinedBy.Exclude:
					throw new InvalidOperationException("Cannot mix Include() and Exclude().");
				case OperatorsDefinedBy.Default:
					OperatorsDefinedBy = OperatorsDefinedBy.Include;
					Operators.Clear();
					break;
			}

			// Determine whether or not the specified operator exists in the collection already.
			if (Operators.Contains(theOperator))
				throw new InvalidOperationException(string.Format("Include() has already been called for operator '{0}'.", theOperator.Name));

			// Add the operator to the collection.
			Operators.Add(theOperator);
		}

		/// <summary>
		/// Removes an operator from the list of supported operators.
		/// </summary>
		/// <param name="theOperator"><seealso cref="OperatorBase"/> consider for exclusion.</param>
		protected void Exclude(OperatorBase theOperator)
		{
			// Determine if we are moving from Default or Include. 
			switch (OperatorsDefinedBy)
			{
				case OperatorsDefinedBy.Include:
					throw new InvalidOperationException("Cannot mix Include() and Exclude().");
				case OperatorsDefinedBy.Default:
					OperatorsDefinedBy = OperatorsDefinedBy.Exclude;
					break;
			}

			// Determine whether or not the specified operator exists in the collection already.
			if (!Operators.Contains(theOperator))
				throw new InvalidOperationException(string.Format("Exclude() has already been called for operator '{0}'.", theOperator.Name));

			// Add the operator to the collection.
			Operators.Remove(theOperator);
		}
	}
}
