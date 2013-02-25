namespace Searchable.Operators
{
	public class DoesNotBeginWithOperator : BaseOperator
	{
		public DoesNotBeginWithOperator()
		{
			Operator = Operators.DoesNotBeginWith;
			Name = "Does Not Begin With";
			Display = "Does Not Begin With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
