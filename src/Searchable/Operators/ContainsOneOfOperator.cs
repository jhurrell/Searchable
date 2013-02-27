namespace SearchBuilder.Operators
{
	public class ContainsOneOfOperator : Operator
	{
		public ContainsOneOfOperator()
		{
			OperatorType = Operators.ContainsOneOf;
			Name = "Contains One Of";
			Display = "Contains One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
