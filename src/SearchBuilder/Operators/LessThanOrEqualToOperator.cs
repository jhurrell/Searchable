namespace SearchBuilder.Operators
{
	public class LessThanOrEqualToOperator : OperatorBase
	{
		public LessThanOrEqualToOperator()
		{
			Name = "LessThanOrEqualTo";
			Symbol = "<=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
