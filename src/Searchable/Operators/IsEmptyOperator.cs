namespace Searchable.Operators
{
	public class IsEmptyOperator : BaseOperator
	{
		public IsEmptyOperator()
		{
			Operator = Operators.IsEmpty;
			Name = "Is Empty";
			Display = "Is Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
