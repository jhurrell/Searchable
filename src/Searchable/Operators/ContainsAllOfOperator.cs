namespace Searchable.Operators
{
	public class ContainsAllOfOperator : Operator
	{
		public ContainsAllOfOperator()
		{
			OperatorType = Operators.ContainsAllOf;
			Name = "Contains All Of";
			Display = "Contains All Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
