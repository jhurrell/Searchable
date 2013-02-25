namespace Searchable.Operators
{
	public class DoesNotContainOperator : BaseOperator
	{
		public DoesNotContainOperator()
		{
			Operator = Operators.DoesNotContain;
			Name = "Does Not Contain";
			Display = "Does Not Contain";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
