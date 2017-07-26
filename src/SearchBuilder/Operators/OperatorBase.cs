using System.Collections.Generic;
using System.Linq;

namespace SearchBuilder.Operators
{
	/// <summary>
	/// Base class for all operators.
	/// </summary>
	public abstract class OperatorBase
	{
		public string Name { get; protected set; }
		public string Symbol { get; protected set; }
		public int MinValuesRequired { get; protected set; }
		public int MaxValuesRequired { get; protected set; }
		public List<object> Values { get; set; }

		protected OperatorBase()
		{
			Values = new List<object>();
		}

		/// <summary>
		/// Defaults the display name.
		/// </summary>
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

		/// <summary>
		/// Tests whether the number of values provided meet the requirements.
		/// </summary>
		/// <returns>true if the number of values provided meet the requirements.</returns>
		public virtual bool IsValid
		{
			get 
			{
				return Values.Count >= MinValuesRequired && Values.Count <= MaxValuesRequired;
			}
		}

		/// <summary>
		/// Determines whether this instance and another specified Operator object have the same value.
		/// </summary>
		/// <param name="obj">The Operator to compare to this instance.</param>
		/// <returns>true if the value of the value parameter is the same as this instance; otherwise, false.</returns>
		public override bool Equals(object obj)
		{
            if (obj == null)
            {
                return false;
            }
 
            if (GetType() != obj.GetType())
            {
                return false;
            }

			return GetHashCode() == obj.GetHashCode();
		}

		/// <summary>
		/// Returns the hash code for this Operator.
		/// </summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			// http://stackoverflow.com/questions/50098/comparing-two-collections-for-equality-irrespective-of-the-order-of-items-in-the
			var valuesHash = Values.OrderBy(x => x).Aggregate(17, (current, val) => current*23 + val.GetHashCode());

			var signature = string.Format("{0}{1}{2}{3}{4}{5}", GetType(), Name, Symbol, MinValuesRequired, MaxValuesRequired, valuesHash);
			return signature.GetHashCode();
		}
	}
}
