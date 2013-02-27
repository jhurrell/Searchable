namespace SearchBuilder.Operators
{
	public class DoesNotHaveValueOperator : Operator
	{
		public DoesNotHaveValueOperator()
		{
			OperatorType = Operators.DoesNotHaveValue;
			Name = "Does Not Have A Value";
			Display = "= Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
