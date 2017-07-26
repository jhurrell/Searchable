namespace SearchBuilder.Operators
{
	public class BeginsWithOperator : OperatorBase
	{
		public BeginsWithOperator()
		{
			Name = "BeginsWith";
			Symbol = "Begins With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
