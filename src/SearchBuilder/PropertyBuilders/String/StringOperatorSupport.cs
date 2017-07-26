using System.Collections.Generic;
using SearchBuilder.Operators;

namespace SearchBuilder.PropertyBuilders.String
{
	/// <summary>
	/// Caches the mapping between the StringOperators enum and the concrete Operator types.
	/// </summary>
	public class StringOperatorSupport
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<OperatorBase> GetOperators()
		{
			return new List<OperatorBase>
			{
				new BeginsWithOperator(),
				new BetweenOperator(),
				new ContainsOperator(),
				new DoesNotBeginWithOperator(),
				new DoesNotContainOperator(),
				new DoesNotEndWithOperator(),
				new DoesNotHaveValueOperator(),
				new EndsWithOperator(),
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
		public static OperatorBase GetOperator(StringOperators op)
		{
			switch(op)
			{
				case StringOperators.BeginsWith:
					return new BeginsWithOperator();
				case StringOperators.Between:
					return new BetweenOperator();
				case StringOperators.Contains:
					return new ContainsOperator();
				case StringOperators.DoesNotBeginWith:
					return new DoesNotBeginWithOperator();
				case StringOperators.DoesNotContain:
					return new DoesNotContainOperator();
				case StringOperators.DoesNotEndWith:
					return new DoesNotEndWithOperator();
				case StringOperators.DoesNotHaveValue:
					return new DoesNotHaveValueOperator();
				case StringOperators.EndsWith:
					return new EndsWithOperator();
				case StringOperators.EqualTo:
					return new EqualToOperator();
				case StringOperators.GreaterThan:
					return new GreaterThanOperator();
				case StringOperators.GreaterThanOrEqualTo:
					return new GreaterThanOrEqualToOperator();
				case StringOperators.HasValue:
					return new HasValueOperator();
				case StringOperators.IsNotOneOf:
					return new IsNotOneOfOperator();
				case StringOperators.IsOneOf:
					return new IsOneOfOperator();
				case StringOperators.LessThan:
					return new LessThanOperator();
				case StringOperators.LessThanOrEqualTo:
					return new LessThanOrEqualToOperator();
				case StringOperators.NotBetween:
					return new NotBetweenOperator();
				default:
					//case StringOperators.NotEqualTo:
					return new NotEqualToOperator();
			}
		}
	}
}
