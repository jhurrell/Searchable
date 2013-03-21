namespace SearchBuilder.Operators
{
	public class GreaterThanOperator : OperatorBase
	{
		public GreaterThanOperator()
		{
			OperatorType = Operator.GreaterThan;
			Name = "GreaterThan";
			Symbol = ">";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
