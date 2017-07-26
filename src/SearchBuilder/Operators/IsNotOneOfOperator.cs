namespace SearchBuilder.Operators
{
	public class IsNotOneOfOperator : OperatorBase
	{
		public IsNotOneOfOperator()
		{
			Name = "IsNotOneOf";
			Symbol = "Is Not One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
