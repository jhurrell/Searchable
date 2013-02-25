using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Searchable.Operators
{
	/// <summary>
	/// Manages the relationships between types and the search operators supported by the types.
	/// </summary>
	public static class OperatorSupport
	{
		public static Dictionary<Type, object> Types { get; private set; }

		static OperatorSupport()
		{
			Types = new Dictionary<Type, object>();

			// Add support for types.
			Types.Add(typeof(DateTime), new object());
			Types.Add(typeof(DateTime?), new object());
			Types.Add(typeof(bool), new object());
			Types.Add(typeof(bool?), new object());
			Types.Add(typeof(byte), new object());
			Types.Add(typeof(byte?), new object());
			Types.Add(typeof(char), new object());
			Types.Add(typeof(char?), new object());
			Types.Add(typeof(decimal), new object());
			Types.Add(typeof(decimal?), new object());
			Types.Add(typeof(double), new object());
			Types.Add(typeof(double?), new object());
			Types.Add(typeof(float), new object());
			Types.Add(typeof(float?), new object());
			Types.Add(typeof(int), new object());
			Types.Add(typeof(int?), new object());
			Types.Add(typeof(long), new object());
			Types.Add(typeof(long?), new object());
			Types.Add(typeof(sbyte), new object());
			Types.Add(typeof(sbyte?), new object());
			Types.Add(typeof(short), new object());
			Types.Add(typeof(short?), new object());
			Types.Add(typeof(uint), new object());
			Types.Add(typeof(uint?), new object());
			Types.Add(typeof(ulong), new object());
			Types.Add(typeof(ulong?), new object());
			Types.Add(typeof(ushort), new object());
			Types.Add(typeof(ushort?), new object());

			Types.Add(typeof(string), new object());
			Types.Add(typeof(IEnumerable), new object());
		}

		public static object GetSupportedOperators(Type type)
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
