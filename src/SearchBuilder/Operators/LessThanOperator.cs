namespace SearchBuilder.Operators
{
	public class LessThanOperator : OperatorBase
	{
		public LessThanOperator()
		{
			Name = "LessThan";
			Symbol = "<";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
