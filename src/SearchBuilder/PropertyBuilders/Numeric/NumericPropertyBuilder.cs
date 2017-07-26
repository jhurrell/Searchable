using System.Reflection;

namespace SearchBuilder.PropertyBuilders.Numeric
{
	/// <summary>
	/// Numeric instance of a Property.
	/// </summary>
	public class NumericPropertyBuilder : PropertyBuilderBase, INumericPropertyBuilder
	{
		public NumericPropertyBuilder(PropertyInfo propertyInfo) : base(propertyInfo)
		{
			Operators = NumericOperatorSupport.GetOperators();
		}

		/// <summary>
		/// Overrides the set of default operators and only includes those specified by the Include() function.
		/// </summary>
		/// <param name="op">Operator to include</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/> this</returns>
		public IInclude Include(NumericOperators op)
		{
			// Retrieve the operator and attempt to add to the collection of supported operators.
			var theOperator = NumericOperatorSupport.GetOperator(op);
			Include(theOperator);

			return this;
		}

		/// <summary>
		/// Overrides the set of default operators and excludes those specified by the Exclude() function.
		/// </summary>
		/// <param name="op">Operator to exclude</param>
		/// <returns><seealso cref="NumericPropertyBuilder"/> this</returns>
		public IExclude Exclude(NumericOperators op)
		{
			// Retrieve the operator and attempt to remove it from the collection of supported operators.
			var theOperator = NumericOperatorSupport.GetOperator(op);
			Exclude(theOperator);

			return this;
		}
	}
}
