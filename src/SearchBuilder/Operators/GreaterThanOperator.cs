namespace SearchBuilder.Operators
{
	public class GreaterThanOperator : OperatorBase
	{
		public GreaterThanOperator()
		{
			Name = "GreaterThan";
			Symbol = ">";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
