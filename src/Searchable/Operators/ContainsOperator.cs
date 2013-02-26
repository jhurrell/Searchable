namespace Searchable.Operators
{
	public class ContainsOperator : Operator
	{
		public ContainsOperator()
		{
			OperatorType = Operators.Contains;
			Name = "Contains";
			Display = "Contains";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
