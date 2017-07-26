namespace SearchBuilder.Operators
{
	public class ContainsOperator : OperatorBase
	{
		public ContainsOperator()
		{
			Name = "Contains";
			Symbol = "Contains";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
