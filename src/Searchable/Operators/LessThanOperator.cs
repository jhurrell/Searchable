namespace SearchBuilder.Operators
{
	public class LessThanOperator : OperatorBase
	{
		public LessThanOperator()
		{
			OperatorType = Operator.LessThan;
			Name = "LessThan";
			Symbol = "<";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
