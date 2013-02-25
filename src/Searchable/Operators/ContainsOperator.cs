namespace Searchable.Operators
{
	public class ContainsOperator : BaseOperator
	{
		public ContainsOperator()
		{
			Operator = Operators.Contains;
			Name = "Contains";
			Display = "Contains";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
