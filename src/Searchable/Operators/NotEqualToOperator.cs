namespace SearchBuilder.Operators
{
	public class NotEqualToOperator : OperatorBase
	{
		public NotEqualToOperator()
		{
			OperatorType = Operator.NotEqualTo;
			Name = "NotEqualTo";
			Symbol = "<>";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
