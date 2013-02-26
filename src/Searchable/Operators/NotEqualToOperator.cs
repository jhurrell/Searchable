namespace Searchable.Operators
{
	public class NotEqualToOperator : Operator
	{
		public NotEqualToOperator()
		{
			OperatorType = Operators.NotEqualTo;
			Name = "Not Equal To";
			Display = "<>";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
