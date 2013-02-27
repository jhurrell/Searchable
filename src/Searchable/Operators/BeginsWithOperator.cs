namespace SearchBuilder.Operators
{
	public class BeginsWithOperator : Operator
	{
		public BeginsWithOperator()
		{
			OperatorType = Operators.BeginsWith;
			Name = "Begins With";
			Display = "Begins With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
