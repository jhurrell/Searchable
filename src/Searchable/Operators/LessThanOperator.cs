namespace SearchBuilder.Operators
{
	public class LessThanOperator : Operator
	{
		public LessThanOperator()
		{
			OperatorType = Operators.LessThan;
			Name = "Less Than";
			Display = "<";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
