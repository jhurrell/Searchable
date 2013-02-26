namespace Searchable.Operators
{
	public class ContainsNoneOfOperator : Operator
	{
		public ContainsNoneOfOperator()
		{
			OperatorType = Operators.ContainsNoneOf;
			Name = "Contains None Of";
			Display = "Contains None Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
