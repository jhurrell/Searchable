namespace SearchBuilder.Operators
{
	public class BetweenOperator : OperatorBase
	{
		public BetweenOperator()
		{
			OperatorType = Operator.Between;
			Name = "Between";
			Symbol = "Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
