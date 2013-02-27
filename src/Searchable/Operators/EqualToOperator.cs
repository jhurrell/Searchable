namespace SearchBuilder.Operators
{
	public class EqualToOperator : Operator
	{
		public EqualToOperator()
		{
			OperatorType = Operators.EqualTo;
			Name = "Equal To";
			Display = "=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
