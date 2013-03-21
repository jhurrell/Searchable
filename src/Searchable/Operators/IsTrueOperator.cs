namespace SearchBuilder.Operators
{
	public class IsTrueOperator : OperatorBase
	{
		public IsTrueOperator()
		{
			OperatorType = Operator.IsTrue;
			Name = "IsTrue";
			Symbol = "True";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
