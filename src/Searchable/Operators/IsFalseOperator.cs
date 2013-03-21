namespace SearchBuilder.Operators
{
	public class IsFalseOperator : OperatorBase
	{
		public IsFalseOperator()
		{
			OperatorType = Operator.IsFalse;
			Name = "IsFalse";
			Symbol = "False";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
