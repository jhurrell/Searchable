namespace SearchBuilder.Operators
{
	public class DoesNotContainOperator : Operator
	{
		public DoesNotContainOperator()
		{
			OperatorType = Operators.DoesNotContain;
			Name = "Does Not Contain";
			Display = "Does Not Contain";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
