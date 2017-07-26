namespace SearchBuilder.Operators
{
	public class DoesNotEndWithOperator : OperatorBase
	{
		public DoesNotEndWithOperator()
		{
			Name = "DoesNotEndWith";
			Symbol = "Does Not End With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
