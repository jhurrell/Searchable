namespace Searchable.Operators
{
	public class EqualToOperator : BaseOperator
	{
		public EqualToOperator()
		{
			Operator = Operators.EqualTo;
			Name = "Equal To";
			Display = "=";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
