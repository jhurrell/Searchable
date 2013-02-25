namespace Searchable.Operators
{
	public class EndsWithOperator : BaseOperator
	{
		public EndsWithOperator()
		{
			Operator = Operators.EndsWith;
			Name = "Ends With";
			Display = "Ends With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
