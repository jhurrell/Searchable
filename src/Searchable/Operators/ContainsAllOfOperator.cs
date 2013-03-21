namespace SearchBuilder.Operators
{
	public class ContainsAllOfOperator : OperatorBase
	{
		public ContainsAllOfOperator()
		{
			OperatorType = Operator.ContainsAllOf;
			Name = "ContainsAllOf";
			Symbol = "Contains All Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
