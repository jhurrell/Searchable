namespace SearchBuilder.Operators
{
	public class HasValueOperator : Operator
	{
		public HasValueOperator()
		{
			OperatorType = Operators.HasValue;
			Name = "Has A Value";
			Display = "<> Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
