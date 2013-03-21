namespace SearchBuilder.Operators
{
	public class DoesNotContainOperator : OperatorBase
	{
		public DoesNotContainOperator()
		{
			OperatorType = Operator.DoesNotContain;
			Name = "DoesNotContain";
			Symbol = "Does Not Contain";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
