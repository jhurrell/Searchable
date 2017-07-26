using System.Reflection;
using SearchBuilder.PropertyBuilders.Collection;

namespace SearchBuilder.PropertyBuilders.Enum
{
	public class EnumPropertyBuilder : PropertyBuilderBase, IEnumPropertyBuilder
	{
		public EnumPropertyBuilder(PropertyInfo propertyInfo) : base(propertyInfo)
		{
			Operators = EnumOperatorSupport.GetOperators();
		}

		/// <summary>
		/// Overrides the set of default operators and only includes those specified by the Include() function.
		/// </summary>
		/// <param name="op">Operator to include</param>
		/// <returns><seealso cref="CollectionPropertyBuilder"/> this</returns>
		public IInclude Include(EnumOperators op)
		{
			// Retrieve the operator and attempt to add to the collection of supported operators.
			var theOperator = EnumOperatorSupport.GetOperator(op);
			Include(theOperator);

			return this;
		}

		/// <summary>
		/// Overrides the set of default operators and excludes those specified by the Exclude() function.
		/// </summary>
		/// <param name="op">Operator to exclude</param>
		/// <returns><seealso cref="CollectionPropertyBuilder"/> this</returns>
		public IExclude Exclude(EnumOperators op)
		{
			// Retrieve the operator and attempt to remove it from the collection of supported operators.
			var theOperator = EnumOperatorSupport.GetOperator(op);
			Exclude(theOperator);

			return this;
		}
	}
}
