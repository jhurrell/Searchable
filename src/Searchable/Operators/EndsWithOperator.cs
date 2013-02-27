namespace SearchBuilder.Operators
{
	public class EndsWithOperator : Operator
	{
		public EndsWithOperator()
		{
			OperatorType = Operators.EndsWith;
			Name = "Ends With";
			Display = "Ends With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
