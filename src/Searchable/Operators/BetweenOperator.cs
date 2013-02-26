namespace Searchable.Operators
{
	public class BetweenOperator : Operator
	{
		public BetweenOperator()
		{
			OperatorType = Operators.Between;
			Name = "Between";
			Display = "Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
