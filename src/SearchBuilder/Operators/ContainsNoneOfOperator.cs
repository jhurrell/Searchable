namespace SearchBuilder.Operators
{
	public class ContainsNoneOfOperator : OperatorBase
	{
		public ContainsNoneOfOperator()
		{
			Name = "ContainsNoneOf";
			Symbol = "Contains None Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
