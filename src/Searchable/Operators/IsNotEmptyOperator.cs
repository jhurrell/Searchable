namespace Searchable.Operators
{
	public class IsNotEmptyOperator : Operator
	{
		public IsNotEmptyOperator()
		{
			OperatorType = Operators.IsNotEmpty;
			Name = "Is Not Empty";
			Display = "Is Not Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
