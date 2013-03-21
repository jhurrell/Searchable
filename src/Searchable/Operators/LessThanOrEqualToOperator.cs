namespace SearchBuilder.Operators
{
	public class LessThanOrEqualToOperator : OperatorBase
	{
		public LessThanOrEqualToOperator()
		{
			OperatorType = Operator.LessThanOrEqualTo;
			Name = "LessThanOrEqualTo";
			Symbol = "<=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
