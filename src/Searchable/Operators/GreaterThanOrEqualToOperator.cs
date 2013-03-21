namespace SearchBuilder.Operators
{
	public class GreaterThanOrEqualToOperator : OperatorBase
	{
		public GreaterThanOrEqualToOperator()
		{
			OperatorType = Operator.GreaterThanOrEqualTo;
			Name = "GreaterThanOrEqualTo";
			Symbol = ">=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
