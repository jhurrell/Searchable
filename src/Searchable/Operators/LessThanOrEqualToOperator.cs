namespace Searchable.Operators
{
	public class LessThanOrEqualToOperator : Operator
	{
		public LessThanOrEqualToOperator()
		{
			OperatorType = Operators.LessThanOrEqualTo;
			Name = "Less Than Or Equal To";
			Display = "<=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
