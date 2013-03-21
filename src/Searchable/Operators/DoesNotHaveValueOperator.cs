namespace SearchBuilder.Operators
{
	public class DoesNotHaveValueOperator : OperatorBase
	{
		public DoesNotHaveValueOperator()
		{
			OperatorType = Operator.DoesNotHaveValue;
			Name = "DoesNotHaveAValue";
			Symbol = "= Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
