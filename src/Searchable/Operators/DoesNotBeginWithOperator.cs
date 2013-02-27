namespace SearchBuilder.Operators
{
	public class DoesNotBeginWithOperator : Operator
	{
		public DoesNotBeginWithOperator()
		{
			OperatorType = Operators.DoesNotBeginWith;
			Name = "Does Not Begin With";
			Display = "Does Not Begin With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
