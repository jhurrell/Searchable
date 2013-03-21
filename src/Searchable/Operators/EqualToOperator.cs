namespace SearchBuilder.Operators
{
	public class EqualToOperator : OperatorBase
	{
		public EqualToOperator()
		{
			OperatorType = Operator.EqualTo;
			Name = "EqualTo";
			Symbol = "=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
