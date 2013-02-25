namespace Searchable.Operators
{
	public class LessThanOrEqualToOperator : BaseOperator
	{
		public LessThanOrEqualToOperator()
		{
			Operator = Operators.LessThanOrEqualTo;
			Name = "Less Than Or Equal To";
			Display = "<=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
