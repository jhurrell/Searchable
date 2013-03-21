namespace SearchBuilder.Operators
{
	public class DoesNotBeginWithOperator : OperatorBase
	{
		public DoesNotBeginWithOperator()
		{
			OperatorType = Operator.DoesNotBeginWith;
			Name = "DoesNotBeginWith";
			Symbol = "Does Not Begin With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
