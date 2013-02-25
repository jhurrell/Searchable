namespace Searchable.Operators
{
	public class DoesNotHaveValueOperator : BaseOperator
	{
		public DoesNotHaveValueOperator()
		{
			Operator = Operators.DoesNotHaveValue;
			Name = "Does Not Have A Value";
			Display = "= Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
