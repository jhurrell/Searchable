namespace Searchable.Operators
{
	public class BetweenOperator : BaseOperator
	{
		public BetweenOperator()
		{
			Operator = Operators.Between;
			Name = "Between";
			Display = "Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
