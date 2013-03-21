namespace SearchBuilder.Operators
{
	public class IsNotEmptyOperator : OperatorBase
	{
		public IsNotEmptyOperator()
		{
			OperatorType = Operator.IsNotEmpty;
			Name = "IsNotEmpty";
			Symbol = "Is Not Empty";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
