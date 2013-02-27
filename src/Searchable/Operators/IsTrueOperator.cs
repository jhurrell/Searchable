namespace SearchBuilder.Operators
{
	public class IsTrueOperator : Operator
	{
		public IsTrueOperator()
		{
			OperatorType = Operators.IsTrue;
			Name = "Is True";
			Display = "True";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
