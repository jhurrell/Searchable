namespace Searchable.Operators
{
	public class IsTrueOperator : BaseOperator
	{
		public IsTrueOperator()
		{
			Operator = Operators.IsTrue;
			Name = "Is True";
			Display = "True";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
