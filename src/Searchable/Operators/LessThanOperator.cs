namespace Searchable.Operators
{
	public class LessThanOperator : BaseOperator
	{
		public LessThanOperator()
		{
			Operator = Operators.LessThan;
			Name = "Less Than";
			Display = "<";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
