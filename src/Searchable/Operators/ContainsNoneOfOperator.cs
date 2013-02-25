namespace Searchable.Operators
{
	public class ContainsNoneOfOperator : BaseOperator
	{
		public ContainsNoneOfOperator()
		{
			Operator = Operators.ContainsNoneOf;
			Name = "Contains None Of";
			Display = "Contains None Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
