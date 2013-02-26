namespace Searchable.Operators
{
	public class NotBetweenOperator : Operator
	{
		public NotBetweenOperator()
		{
			OperatorType = Operators.NotBetween;
			Name = "Not Between";
			Display = "Not Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
