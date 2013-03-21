namespace SearchBuilder.Operators
{
	public class IsOneOfOperator : OperatorBase
	{
		public IsOneOfOperator()
		{
			OperatorType = Operator.IsOneOf;
			Name = "IsOneOf";
			Symbol = "Is One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
