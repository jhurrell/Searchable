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
		public static Dictionary<Operator, OperatorBase> Operators { get; private set; }

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


			// Map types to the operators they support.
			Types = new Dictionary<Type, List<OperatorBase>>();
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


			// Cache a dictionary of operators by the enum.
			Operators = new Dictionary<Operator, OperatorBase>();
			Operators.Add(Operator.BeginsWith, new BeginsWithOperator());
			Operators.Add(Operator.Between, new BetweenOperator());
			Operators.Add(Operator.ContainsAllOf, new ContainsAllOfOperator());
			Operators.Add(Operator.ContainsNoneOf, new ContainsNoneOfOperator());
			Operators.Add(Operator.ContainsOneOf, new ContainsOneOfOperator());
			Operators.Add(Operator.Contains, new ContainsOperator());
			Operators.Add(Operator.DoesNotBeginWith, new DoesNotBeginWithOperator());
			Operators.Add(Operator.DoesNotContain, new DoesNotContainOperator());
			Operators.Add(Operator.DoesNotEndWith, new DoesNotEndWithOperator());
			Operators.Add(Operator.DoesNotHaveValue, new DoesNotHaveValueOperator());
			Operators.Add(Operator.EndsWith, new EndsWithOperator());
			Operators.Add(Operator.EqualTo, new EqualToOperator());
			Operators.Add(Operator.GreaterThan, new GreaterThanOperator());
			Operators.Add(Operator.GreaterThanOrEqualTo, new GreaterThanOrEqualToOperator());
			Operators.Add(Operator.HasValue, new HasValueOperator());
			Operators.Add(Operator.IsEmpty, new IsEmptyOperator());
			Operators.Add(Operator.IsFalse, new IsFalseOperator());
			Operators.Add(Operator.IsNotEmpty, new IsNotEmptyOperator());
			Operators.Add(Operator.IsNotOneOf, new IsNotOneOfOperator());
			Operators.Add(Operator.IsOneOf, new IsOneOfOperator());
			Operators.Add(Operator.IsTrue, new IsTrueOperator());
			Operators.Add(Operator.LessThan, new LessThanOperator());
			Operators.Add(Operator.LessThanOrEqualTo, new LessThanOrEqualToOperator());
			Operators.Add(Operator.NotBetween, new NotBetweenOperator());
			Operators.Add(Operator.NotEqualTo, new NotEqualToOperator());    
		}

		/// <summary>
		/// Returns the operators supported for the type.
		/// </summary>
		/// <param name="type">Type of object.</param>
		/// <returns><seealso cref="List<>"/> of <seealso cref="Operator"/></returns>
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <param name="op"></param>
		/// <returns></returns>
		public static bool IsOperatorSupportedByType(Type type, Operator op)
		{
			// Is the type one we support?
			if(!IsTypeSupported(type))
				return false;

			// The type is one we support.
			var operators = GetSupportedOperators(type);
			return operators.Any(o => o.OperatorType == op);
		}
	}
}
