using System;
using System.Collections;
using System.Collections.Generic;

namespace Searchable.Operators
{
	/// <summary>
	/// Manages the relationships between types and the search operators supported by the types.
	/// </summary>
	public static class OperatorSupport
	{
		public static Dictionary<Type, List<BaseOperator>> Types { get; private set; }

		static OperatorSupport()
		{
			// Cache operators by types.
			var commonOperators = new List<BaseOperator> 
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

			var boolOperators = new List<BaseOperator>
			{
				new DoesNotHaveValueOperator(),
				new HasValueOperator(),
				new IsFalseOperator(),
				new IsTrueOperator(),
			};

			var stringOperators = new List<BaseOperator>
			{
				new BeginsWithOperator(),
				new ContainsOperator(),
				new DoesNotContainOperator(),
				new EndsWithOperator(),
			};
			stringOperators.AddRange(commonOperators);

			var collectionOperators = new List<BaseOperator>
			{
				new IsEmptyOperator(),
				new IsNotEmptyOperator(),
				new ContainsOneOfOperator(),
				new ContainsNoneOfOperator(),
				new ContainsAllOfOperator(),
			};


			// Map types to the operators they support.
			Types = new Dictionary<Type, List<BaseOperator>>();
			Types.Add(typeof(DateTime), commonOperators);
			Types.Add(typeof(DateTime?), commonOperators);
			Types.Add(typeof(bool), boolOperators);
			Types.Add(typeof(bool?), boolOperators);
			Types.Add(typeof(byte), commonOperators);
			Types.Add(typeof(byte?), commonOperators);
			Types.Add(typeof(char), commonOperators);
			Types.Add(typeof(char?), commonOperators);
			Types.Add(typeof(decimal), commonOperators);
			Types.Add(typeof(decimal?), commonOperators);
			Types.Add(typeof(double), commonOperators);
			Types.Add(typeof(double?), commonOperators);
			Types.Add(typeof(float), commonOperators);
			Types.Add(typeof(float?), commonOperators);
			Types.Add(typeof(int), commonOperators);
			Types.Add(typeof(int?), commonOperators);
			Types.Add(typeof(long), commonOperators);
			Types.Add(typeof(long?), commonOperators);
			Types.Add(typeof(sbyte), commonOperators);
			Types.Add(typeof(sbyte?), commonOperators);
			Types.Add(typeof(short), commonOperators);
			Types.Add(typeof(short?), commonOperators);
			Types.Add(typeof(uint), commonOperators);
			Types.Add(typeof(uint?), commonOperators);
			Types.Add(typeof(ulong), commonOperators);
			Types.Add(typeof(ulong?), commonOperators);
			Types.Add(typeof(ushort), commonOperators);
			Types.Add(typeof(ushort?), commonOperators);

			Types.Add(typeof(string), stringOperators);
			Types.Add(typeof(IEnumerable), collectionOperators);
		}

		public static List<BaseOperator> GetSupportedOperators(Type type)
		{
			if (type != typeof(string) && !type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type))
				type = typeof(IEnumerable);

			if (type != typeof(string) && type.IsGenericType && typeof(IEnumerable<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
				type = typeof(IEnumerable);

			if (!Types.ContainsKey(type))
				throw new ArgumentException(string.Format("The type specified ({0}) is not supported.", type));

			return Types[type];
		}
	}
}
