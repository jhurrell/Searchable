﻿namespace SearchBuilder.Operators
{
	public class HasValueOperator : OperatorBase
	{
		public HasValueOperator()
		{
			Name = "HasAValue";
			Symbol = "<> Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
