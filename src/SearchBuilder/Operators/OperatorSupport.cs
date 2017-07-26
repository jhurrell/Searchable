using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace SearchBuilder.Operators
{
	/// <summary>
	/// Manages the relationships between types and the search operators supported by the types.
	/// </summary>
	public static class OperatorSupport
	{
		public static Dictionary<Type, List<OperatorBase>> Types { get; private set; }

		/// <summary>
		/// Initializes a new static instance of OperatorSupport.
		/// </summary>
		static OperatorSupport()
		{
			// Cache operators by types.
			var commonOperators = new List<OperatorBase> 
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

			var boolOperators = new List<OperatorBase>
			{
				new DoesNotHaveValueOperator(),
				new HasValueOperator(),
				new IsFalseOperator(),
				new IsTrueOperator(),
			};

			var stringOperators = new List<OperatorBase>
			{
				new BeginsWithOperator(),
				new ContainsOperator(),
				new DoesNotContainOperator(),
				new EndsWithOperator(),
			};
			stringOperators.AddRange(commonOperators);

			var collectionOperators = new List<OperatorBase>
			{
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),
				new ContainsOneOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsAllOfOperator(),
			};

			var enumOperators = new List<OperatorBase>
			{
				new NotEqualToOperator(),
				new EqualToOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
			};


			// Map types to the operators they support.
			Types = new Dictionary<Type, List<OperatorBase>>
			{
				{typeof (DateTime), commonOperators},
				{typeof (bool), boolOperators},
				{typeof (byte), commonOperators},
				{typeof (char), commonOperators},
				{typeof (decimal), commonOperators},
				{typeof (double), commonOperators},
				{typeof (float), commonOperators},
				{typeof (int), commonOperators},
				{typeof (long), commonOperators},
				{typeof (sbyte), commonOperators},
				{typeof (short), commonOperators},
				{typeof (uint), commonOperators},
				{typeof (ulong), commonOperators},
				{typeof (ushort), commonOperators},
				{typeof (string), stringOperators},
				{typeof (IEnumerable), collectionOperators},
				{typeof (Enum), enumOperators },
			};
		}

		/// <summary>
		/// Returns the operators supported for the type.
		/// </summary>
		/// <param name="type">Type of object.</param>
		/// <returns>List of <seealso cref="OperatorBase"/></returns>
		public static List<OperatorBase> GetSupportedOperators(Type type)
		{
			type = GetCompatibleType(type);
			if (!Types.ContainsKey(type))
				throw new ArgumentException(string.Format("The type specified ({0}) is not supported.", type));

			return Types[type].ToList();
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

			// Determine if type is Enum.
			if (type.IsEnum)
				return typeof(Enum);

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
