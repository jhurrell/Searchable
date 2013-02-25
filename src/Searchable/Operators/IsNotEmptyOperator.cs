namespace Searchable.Operators
{
	public class IsNotEmptyOperator : BaseOperator
	{
		public IsNotEmptyOperator()
		{
			Operator = Operators.IsNotEmpty;
			Name = "Is Not Empty";
			Display = "Is Not Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
