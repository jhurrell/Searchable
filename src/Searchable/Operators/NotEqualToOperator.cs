namespace Searchable.Operators
{
	public class NotEqualToOperator : BaseOperator
	{
		public NotEqualToOperator()
		{
			Operator = Operators.NotEqualTo;
			Name = "Not Equal To";
			Display = "<>";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
