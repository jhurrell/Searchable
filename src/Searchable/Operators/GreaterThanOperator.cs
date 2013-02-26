namespace Searchable.Operators
{
	public class GreaterThanOperator : Operator
	{
		public GreaterThanOperator()
		{
			OperatorType = Operators.GreaterThan;
			Name = "Greater Than";
			Display = ">";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
