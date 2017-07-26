using System.Reflection;

namespace SearchBuilder.PropertyBuilders.Collection
{
	/// <summary>
	/// Collection instance of a Property.
	/// </summary>
	public class CollectionPropertyBuilder : PropertyBuilderBase, ICollectionPropertyBuilder
	{
		public CollectionPropertyBuilder(PropertyInfo propertyInfo) : base(propertyInfo)
		{
			Operators = CollectionOperatorSupport.GetOperators();
		}

		/// <summary>
		/// Overrides the set of default operators and only includes those specified by the Include() function.
		/// </summary>
		/// <param name="op">Operator to include</param>
		/// <returns><seealso cref="CollectionPropertyBuilder"/> this</returns>
		public IInclude Include(CollectionOperators op)
		{
			// Retrieve the operator and attempt to add to the collection of supported operators.
			var theOperator = CollectionOperatorSupport.GetOperator(op);
			Include(theOperator);

			return this;
		}

		/// <summary>
		/// Overrides the set of default operators and excludes those specified by the Exclude() function.
		/// </summary>
		/// <param name="op">Operator to exclude</param>
		/// <returns><seealso cref="CollectionPropertyBuilder"/> this</returns>
		public IExclude Exclude(CollectionOperators op)
		{
			// Retrieve the operator and attempt to remove it from the collection of supported operators.
			var theOperator = CollectionOperatorSupport.GetOperator(op);
			Exclude(theOperator);

			return this;
		}
	}
}
