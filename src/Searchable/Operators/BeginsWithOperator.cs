namespace Searchable.Operators
{
	public class BeginsWithOperator : BaseOperator
	{
		public BeginsWithOperator()
		{
			Operator = Operators.BeginsWith;
			Name = "Begins With";
			Display = "Begins With";
			MinValuesRequired = 1;
			MaxValuesRequired = 1;
		}
	}
}
