namespace SearchBuilder.Operators
{
	public class ContainsAllOfOperator : OperatorBase
	{
		public ContainsAllOfOperator()
		{
			Name = "ContainsAllOf";
			Symbol = "Contains All Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
