using System.Collections.Generic;
using SearchBuilder.Operators;

namespace SearchBuilder.PropertyBuilders.Numeric
{
	/// <summary>
	/// Caches the mapping between the NumericOperators enum and the concrete Operator types.
	/// </summary>
	public class NumericOperatorSupport
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<OperatorBase> GetOperators()
		{
			return new List<OperatorBase>
			{
				new BetweenOperator(),
				new DoesNotHaveValueOperator(),
				new EqualToOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
				new NotBetweenOperator(),
				new NotEqualToOperator(),
			};
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		public static OperatorBase GetOperator(NumericOperators op)
		{
			switch(op)
			{
				case NumericOperators.Between:
					return new BetweenOperator();
				case NumericOperators.DoesNotHaveValue:
					return new DoesNotHaveValueOperator();
				case NumericOperators.EqualTo:
					return new EqualToOperator();
				case NumericOperators.GreaterThan:
					return new GreaterThanOperator();
				case NumericOperators.GreaterThanOrEqualTo:
					return new GreaterThanOrEqualToOperator();
				case NumericOperators.HasValue:
					return new HasValueOperator();
				case NumericOperators.IsNotOneOf:
					return new IsNotOneOfOperator();
				case NumericOperators.IsOneOf:
					return new IsOneOfOperator();
				case NumericOperators.LessThan:
					return new LessThanOperator();
				case NumericOperators.LessThanOrEqualTo:
					return new LessThanOrEqualToOperator();
				case NumericOperators.NotBetween:
					return new NotBetweenOperator();
				default:
					//case NumericOperators.NotEqualTo:
					return new NotEqualToOperator();
			}
		}
	}
}
