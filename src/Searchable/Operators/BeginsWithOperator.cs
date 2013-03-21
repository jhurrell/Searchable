namespace SearchBuilder.Operators
{
	public class BeginsWithOperator : OperatorBase
	{
		public BeginsWithOperator()
		{
			OperatorType = Operator.BeginsWith;
			Name = "BeginsWith";
			Symbol = "Begins With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
