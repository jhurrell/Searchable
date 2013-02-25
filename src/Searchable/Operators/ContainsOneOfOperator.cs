namespace Searchable.Operators
{
	public class ContainsOneOfOperator : BaseOperator
	{
		public ContainsOneOfOperator()
		{
			Operator = Operators.ContainsOneOf;
			Name = "Contains One Of";
			Display = "Contains One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
