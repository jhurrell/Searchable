namespace Searchable.Operators
{
	public class GreaterThanOperator : BaseOperator
	{
		public GreaterThanOperator()
		{
			Operator = Operators.GreaterThan;
			Name = "Greater Than";
			Display = ">";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
