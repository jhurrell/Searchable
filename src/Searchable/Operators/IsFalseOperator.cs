namespace SearchBuilder.Operators
{
	public class IsFalseOperator : Operator
	{
		public IsFalseOperator()
		{
			OperatorType = Operators.IsFalse;
			Name = "Is False";
			Display = "False";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
