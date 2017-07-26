namespace SearchBuilder.Operators
{
	public class DoesNotContainOperator : OperatorBase
	{
		public DoesNotContainOperator()
		{
			Name = "DoesNotContain";
			Symbol = "Does Not Contain";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
