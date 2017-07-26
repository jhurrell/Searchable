namespace SearchBuilder.Operators
{
	public class NotEqualToOperator : OperatorBase
	{
		public NotEqualToOperator()
		{
			Name = "NotEqualTo";
			Symbol = "<>";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
