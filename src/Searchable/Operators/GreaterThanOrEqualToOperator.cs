namespace Searchable.Operators
{
	public class GreaterThanOrEqualToOperator : BaseOperator
	{
		public GreaterThanOrEqualToOperator()
		{
			Operator = Operators.GreaterThanOrEqualTo;
			Name = "Greater Than Or Equal To";
			Display = ">=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
