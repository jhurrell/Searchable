namespace SearchBuilder.Operators
{
	public class EndsWithOperator : OperatorBase
	{
		public EndsWithOperator()
		{
			OperatorType = Operator.EndsWith;
			Name = "EndsWith";
			Symbol = "Ends With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
