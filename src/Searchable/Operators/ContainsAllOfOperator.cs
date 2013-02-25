namespace Searchable.Operators
{
	public class ContainsAllOfOperator : BaseOperator
	{
		public ContainsAllOfOperator()
		{
			Operator = Operators.ContainsAllOf;
			Name = "Contains All Of";
			Display = "Contains All Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
