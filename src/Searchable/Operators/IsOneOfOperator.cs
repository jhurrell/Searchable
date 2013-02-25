namespace Searchable.Operators
{
	public class IsOneOfOperator : BaseOperator
	{
		public IsOneOfOperator()
		{
			Operator = Operators.IsOneOf;
			Name = "Is One Of";
			Display = "Is One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
