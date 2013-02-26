namespace Searchable.Operators
{
	public class IsEmptyOperator : Operator
	{
		public IsEmptyOperator()
		{
			OperatorType = Operators.IsEmpty;
			Name = "Is Empty";
			Display = "Is Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
