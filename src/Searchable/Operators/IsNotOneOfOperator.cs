namespace Searchable.Operators
{
	public class IsNotOneOfOperator : Operator
	{
		public IsNotOneOfOperator()
		{
			OperatorType = Operators.IsNotOneOf;
			Name = "Is Not One Of";
			Display = "Is Not One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
