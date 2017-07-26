using System.Collections.Generic;
using SearchBuilder.Operators;

namespace SearchBuilder.PropertyBuilders.Collection
{
	/// <summary>
	/// Caches the mapping between the StringOperators enum and the concrete Operator types.
	/// </summary>
	public static class CollectionOperatorSupport
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<OperatorBase> GetOperators()
		{
			return new List<OperatorBase>
			{
				new ContainsAllOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsOneOfOperator(),
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),
			};
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		public static OperatorBase GetOperator(CollectionOperators op)
		{
			switch(op)
			{
				case CollectionOperators.ContainsAllOf:
					return new ContainsAllOfOperator();
				case CollectionOperators.ContainsNoneOf:
					return new ContainsNoneOfOperator();
				case CollectionOperators.ContainsOneOf:
					return new ContainsOneOfOperator();
				case CollectionOperators.IsEmpty:
					return new IsEmptyOperator();
				default:
					//case CollectionOperators.IsNotEmpty:
					return new IsNotEmptyOperator();
			}
		}
	}
}
