using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchBuilder.Operators
{
	/// <summary>
	/// Manages the relationships between types and the search operators supported by the types.
	/// </summary>
	public static class OperatorSupport
	{
		public static Dictionary<Type, List<Operator>> Types { get; private set; }

		/// <summary>
		/// Initializes a new static instance of OperatorSupport.
		/// </summary>
		static OperatorSupport()
		{
			// Cache operators by types.
			var commonOperators = new List<Operator> 
			{
				new BetweenOperator(),
				new NotEqualToOperator(),
				new DoesNotHaveValueOperator(),
				new EqualToOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
			};

			var boolOperators = new List<Operator>
			{
				new DoesNotHaveValueOperator(),
				new HasValueOperator(),
				new IsFalseOperator(),
				new IsTrueOperator(),
			};

			var stringOperators = new List<Operator>
			{
				new BeginsWithOperator(),
				new ContainsOperator(),
				new DoesNotContainOperator(),
				new EndsWithOperator(),
			};
			stringOperators.AddRange(commonOperators);

			var collectionOperators = new List<Operator>
			{
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),
				new ContainsOneOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsAllOfOperator(),
			};


			// Map types to the operators they support.
			Types = new Dictionary<Type, List<Operator>>();
			Types.Add(typeof(DateTime), commonOperators);
			Types.Add(typeof(bool), boolOperators);
			Types.Add(typeof(byte), commonOperators);
			Types.Add(typeof(char), commonOperators);
			Types.Add(typeof(decimal), commonOperators);
			Types.Add(typeof(double), commonOperators);
			Types.Add(typeof(float), commonOperators);
			Types.Add(typeof(int), commonOperators);
			Types.Add(typeof(long), commonOperators);
			Types.Add(typeof(sbyte), commonOperators);
			Types.Add(typeof(short), commonOperators);
			Types.Add(typeof(uint), commonOperators);
			Types.Add(typeof(ulong), commonOperators);
			Types.Add(typeof(ushort), commonOperators);
			Types.Add(typeof(string), stringOperators);
			Types.Add(typeof(IEnumerable), collectionOperators);
		}

		/// <summary>
		/// Returns the operators supported for the type.
		/// </summary>
		/// <param name="type">Type of object.</param>
		/// <returns><seealso cref="List<>"/> of <seealso cref="Operator"/></returns>
		public static List<Operator> GetSupportedOperators(Type type)
		{
			type = GetCompatibleType(type);
			if (!Types.ContainsKey(type))
				throw new ArgumentException(string.Format("The type specified ({0}) is not supported.", type));

			return Types[type];
		}

		/// <summary>
		/// Returns the compatible type if exists, otherwise the passed type.
		/// </summary>
		/// <param name="type">Type ofthe object.</param>
		/// <returns>Type which is compatible.</returns>
		public static Type GetCompatibleType(Type type)
		{
			// Determine if the type implements IEnumerable.
			if (type != typeof(string) && !type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type))
				return typeof(IEnumerable);

			// Determine if the type implements IEnumerable<>.
			if (type != typeof(string) && type.IsGenericType && typeof(IEnumerable<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
				return typeof(IEnumerable);

			// Determine if the type is Nullable.
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
				return type.GetGenericArguments()[0];

			return type;
		}

		/// <summary>
		/// Determines if the passed type is one supported by the framework.
		/// </summary>
		/// <param name="type">Type of object.</param>
		/// <returns>true is supported, false if not.</returns>
		public static bool IsTypeSupported(Type type)
		{
			type = GetCompatibleType(type);
			return Types.ContainsKey(type);
		}
	}
}
