using System.Collections.Generic;
using SearchBuilder.Operators;

namespace SearchBuilder.PropertyBuilders.Enum
{
	public class EnumOperatorSupport
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<OperatorBase> GetOperators()
		{
			return new List<OperatorBase>
			{
				new EqualToOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new NotEqualToOperator(),
			};
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		public static OperatorBase GetOperator(EnumOperators op)
		{
			switch (op)
			{
				case EnumOperators.EqualTo:
					return new EqualToOperator();
				case EnumOperators.IsNotOneOf:
					return new IsNotOneOfOperator();
				case EnumOperators.IsOneOf:
					return new IsOneOfOperator();
				default:
					return new NotEqualToOperator();
			}
		}
	}
}
