namespace Searchable.Operators
{
	public class HasValueOperator : BaseOperator
	{
		public HasValueOperator()
		{
			Operator = Operators.HasValue;
			Name = "Has A Value";
			Display = "<> Null";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
