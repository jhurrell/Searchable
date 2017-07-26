namespace SearchBuilder.Operators
{
	public class GreaterThanOrEqualToOperator : OperatorBase
	{
		public GreaterThanOrEqualToOperator()
		{
			Name = "GreaterThanOrEqualTo";
			Symbol = ">=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
