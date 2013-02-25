namespace Searchable.Operators
{
	public abstract class BaseOperator
	{
		public Operators Operator { get; protected set; }
		public string Name { get; protected set; }
		public string Display { get; protected set; }
		public int MinValuesRequired { get; protected set; }
		public int MaxValuesRequired { get; protected set; }
	}
}
