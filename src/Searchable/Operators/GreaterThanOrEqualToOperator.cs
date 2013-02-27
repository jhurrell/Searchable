namespace SearchBuilder.Operators
{
	public class GreaterThanOrEqualToOperator : Operator
	{
		public GreaterThanOrEqualToOperator()
		{
			OperatorType = Operators.GreaterThanOrEqualTo;
			Name = "Greater Than Or Equal To";
			Display = ">=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
