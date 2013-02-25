namespace Searchable.Operators
{
	public class DoesNotEndWithOperator : BaseOperator
	{
		public DoesNotEndWithOperator()
		{
			Operator = Operators.DoesNotEndWith;
			Name = "Does Not End With";
			Display = "Does Not End With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
