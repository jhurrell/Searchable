namespace SearchBuilder.Operators
{
	public class EqualToOperator : OperatorBase
	{
		public EqualToOperator()
		{
			Name = "EqualTo";
			Symbol = "=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
