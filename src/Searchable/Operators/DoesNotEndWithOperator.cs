namespace SearchBuilder.Operators
{
	public class DoesNotEndWithOperator : OperatorBase
	{
		public DoesNotEndWithOperator()
		{
			OperatorType = Operator.DoesNotEndWith;
			Name = "DoesNotEndWith";
			Symbol = "Does Not End With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
