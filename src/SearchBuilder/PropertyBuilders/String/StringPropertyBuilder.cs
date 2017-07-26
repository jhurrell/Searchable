using System.Reflection;

namespace SearchBuilder.PropertyBuilders.String
{
	/// <summary>
	/// String instance of a Property.
	/// </summary>
	public class StringPropertyBuilder : PropertyBuilderBase, IStringPropertyBuilder
	{
		public StringPropertyBuilder(PropertyInfo propertyInfo) : base(propertyInfo)
		{
			Operators = StringOperatorSupport.GetOperators();
		}

		/// <summary>
		/// Overrides the set of default operators and only includes those specified by the Include() function.
		/// </summary>
		/// <param name="op">Operator to include</param>
		/// <returns><seealso cref="StringPropertyBuilder"/> this</returns>
		public IInclude Include(StringOperators op)
		{
			// Retrieve the operator and attempt to add to the collection of supported operators.
			var theOperator = StringOperatorSupport.GetOperator(op);
			Include(theOperator);

			return this;
		}

		/// <summary>
		/// Overrides the set of default operators and excludes those specified by the Exclude() function.
		/// </summary>
		/// <param name="op">Operator to exclude</param>
		/// <returns><seealso cref="StringPropertyBuilder"/> this</returns>
		public IExclude Exclude(StringOperators op)
		{
			// Retrieve the operator and attempt to remove it from the collection of supported operators.
			var theOperator = StringOperatorSupport.GetOperator(op);
			Exclude(theOperator);

			return this;
		}
	}
}
