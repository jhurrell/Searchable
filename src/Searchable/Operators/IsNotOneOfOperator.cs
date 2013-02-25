namespace Searchable.Operators
{
	public class IsNotOneOfOperator : BaseOperator
	{
		public IsNotOneOfOperator()
		{
			Operator = Operators.IsNotOneOf;
			Name = "Is Not One Of";
			Display = "Is Not One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
