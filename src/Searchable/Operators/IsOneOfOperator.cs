namespace SearchBuilder.Operators
{
	public class IsOneOfOperator : Operator
	{
		public IsOneOfOperator()
		{
			OperatorType = Operators.IsOneOf;
			Name = "Is One Of";
			Display = "Is One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
