namespace SearchBuilder.Operators
{
	public class NotBetweenOperator : OperatorBase
	{
		public NotBetweenOperator()
		{
			OperatorType = Operator.NotBetween;
			Name = "NotBetween";
			Symbol = "Not Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
