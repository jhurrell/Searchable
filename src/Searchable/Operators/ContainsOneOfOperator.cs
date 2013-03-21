﻿namespace SearchBuilder.Operators
{
	public class ContainsOneOfOperator : OperatorBase
	{
		public ContainsOneOfOperator()
		{
			OperatorType = Operator.ContainsOneOf;
			Name = "ContainsOneOf";
			Symbol = "Contains One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
