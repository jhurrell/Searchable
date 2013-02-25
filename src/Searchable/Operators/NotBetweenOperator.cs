namespace Searchable.Operators
{
	public class NotBetweenOperator : BaseOperator
	{
		public NotBetweenOperator()
		{
			Operator = Operators.NotBetween;
			Name = "Not Between";
			Display = "Not Between";
			MinValuesRequired = 2;
			MaxValuesRequired = 2;
		}
	}
}
