namespace SearchBuilder.Operators
{
	public abstract class Operator
	{
		public Operators OperatorType { get; protected set; }
		public string Name { get; protected set; }
		public string Display { get; protected set; }
		public int MinValuesRequired { get; protected set; }
		public int MaxValuesRequired { get; protected set; }

		public override bool Equals(object obj)
		{
			Operator item = obj as Operator;
			return item.OperatorType == this.OperatorType;		
		}

		public override int GetHashCode()
		{
			return OperatorType.GetHashCode();
		}
	}
}
