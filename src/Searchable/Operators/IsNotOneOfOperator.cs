namespace SearchBuilder.Operators
{
	public class IsNotOneOfOperator : OperatorBase
	{
		public IsNotOneOfOperator()
		{
			OperatorType = Operator.IsNotOneOf;
			Name = "IsNotOneOf";
			Symbol = "Is Not One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
