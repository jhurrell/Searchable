namespace Searchable.Operators
{
	public class IsFalseOperator : BaseOperator
	{
		public IsFalseOperator()
		{
			Operator = Operators.IsFalse;
			Name = "Is False";
			Display = "False";
			MinValuesRequired = 0;
			MaxValuesRequired = 0;
		}
	}
}
