namespace SearchBuilder.Operators
{
	public class ContainsOperator : OperatorBase
	{
		public ContainsOperator()
		{
			OperatorType = Operator.Contains;
			Name = "Contains";
			Symbol = "Contains";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
