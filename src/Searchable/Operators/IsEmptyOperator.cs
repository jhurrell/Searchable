namespace SearchBuilder.Operators
{
	public class IsEmptyOperator : OperatorBase
	{
		public IsEmptyOperator()
		{
			OperatorType = Operator.IsEmpty;
			Name = "IsEmpty";
			Symbol = "Is Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
