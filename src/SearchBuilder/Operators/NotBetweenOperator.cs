namespace SearchBuilder.Operators
{
	public class NotBetweenOperator : OperatorBase
	{
		public NotBetweenOperator()
		{
			Name = "NotBetween";
			Symbol = "Not Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
