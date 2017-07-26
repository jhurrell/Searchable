namespace SearchBuilder.Operators
{
	public class IsOneOfOperator : OperatorBase
	{
		public IsOneOfOperator()
		{
			Name = "IsOneOf";
			Symbol = "Is One Of";
			MinValuesRequired = 1;
			MaxValuesRequired = int.MaxValue;
		}
	}
}
