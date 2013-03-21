using SearchBuilder.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SearchBuilder
{
	public class Property : IProperty
	{
		public string Name { get; protected set; }
		public string DisplayName { get; protected set; }
		public List<OperatorBase> Operators { get; protected set; }
		private OperatorsDefinedBy OperatorsDefinedBy { get; set; }
		private PropertyInfo PropertyInfo { get; set; }

		/// <summary>
		/// Creates a new instance of a Property with the specified <seealso cref="PropertyInfo"/>.
		/// </summary>
		public Property(PropertyInfo propertyInfo)
		{
			Name = propertyInfo.Name;
			OperatorsDefinedBy = OperatorsDefinedBy.Default;
			PropertyInfo = propertyInfo;

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
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public OperatorBase this[string name]
		{
			get
			{
				return Operators.Where(o => o.Name == name).FirstOrDefault();
			}
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

		/// <summary>
		/// Overrides the default operarors associated with a property and provides a means of explicitely specifying which operators
		/// are to be supported for the property.
		/// </summary>
		/// <param name="op"><seealso cref="Operator"/> enum identifying the operator to support.</param>
		/// <returns><seealso cref="IProperty"/> to continue defining the property.</returns>
		public IProperty AddOperator(Operator op)
		{
			// Change the method by which we identify supported operators.
			if (OperatorsDefinedBy != OperatorsDefinedBy.AddOperator)
			{
				OperatorsDefinedBy = OperatorsDefinedBy.AddOperator;
				Operators.Clear();
			}

			// Verify the operator is supported by the type.
			if(!OperatorSupport.IsOperatorSupportedByType(PropertyInfo.PropertyType, op))
				throw new ArgumentException(string.Format("AddOperator called with invalid combination of property type ({0}) and operator ({1}).", PropertyInfo.PropertyType.ToString(), op.ToString()));

			// Verify the operator has not already been added.
			if (Operators.Any(p => p.OperatorType == op))
				throw new ArgumentException(string.Format("AddOperator already called for operator {0}.", op));

			// Add to the collection.
			Operators.Add(OperatorSupport.Operators[op]);

			return this;
		}

		/// <summary>
		/// Removes the specified operator from the list of those supported by the property.
		/// </summary>
		/// <param name="op"><seealso cref="Operator"/> enum identifying the operator to remove.</param>
		/// <returns><seealso cref="IProperty"/> to continue defining the property.</returns>
		public IProperty RemoveOperator(Operator op)
		{
			// Change the method by which we identify supported operators.
			if (OperatorsDefinedBy != OperatorsDefinedBy.RemoveOperator)
			{
				OperatorsDefinedBy = OperatorsDefinedBy.RemoveOperator;
			}

			// Verify the operator is supported by the type.
			if (!OperatorSupport.IsOperatorSupportedByType(PropertyInfo.PropertyType, op))
				throw new ArgumentException(string.Format("RemoveOperator called with invalid combination of property type ({0}) and operator ({1}).", PropertyInfo.PropertyType.ToString(), op.ToString()));

			// Make sure the operator has not already been removed.
			if (!Operators.Any(p => p.OperatorType == op))
				throw new ArgumentException(string.Format("RemoveOperator already called for operator {0}.", op.ToString()));

			// Remove from the collection.
			var toRemove = Operators.Where(o => o.OperatorType == op).FirstOrDefault();
			Operators.Remove(toRemove);

			return this;
		}
	}
}
