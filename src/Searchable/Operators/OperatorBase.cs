using System.Linq;

namespace SearchBuilder.Operators
{
	public abstract class OperatorBase
	{
		public Operator OperatorType { get; protected set; }
		public string Name { get; protected set; }
		public string Symbol { get; protected set; }
		public int MinValuesRequired { get; protected set; }
		public int MaxValuesRequired { get; protected set; }

		public string DisplayName
		{
			get
			{
				return string.Join
					(
						string.Empty,
						Name.Select((x, i) => (char.IsUpper(x) && i > 0 && (char.IsLower(Name[i - 1]) || (i < Name.Count() - 1 && char.IsLower(Name[i + 1])))) ? " " + x : x.ToString())
					);
			}
		}

		public override bool Equals(object obj)
		{
			OperatorBase item = obj as OperatorBase;
			return item.OperatorType == this.OperatorType;		
		}

		public override int GetHashCode()
		{
			return OperatorType.GetHashCode();
		}
	}
}
