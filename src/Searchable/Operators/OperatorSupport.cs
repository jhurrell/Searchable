using System;
using System.Collections.Generic;

namespace Searchable.Operators
{
	public class OperatorSupport
	{
		public Dictionary<Type, object> Types { get; private set; }

		public OperatorSupport()
		{
			Types = new Dictionary<Type, object>();

			// Numeric types.
			Types.Add(typeof(bool), new object());
			Types.Add(typeof(byte), new object());
			Types.Add(typeof(char), new object());
			Types.Add(typeof(DateTime), new object());
			Types.Add(typeof(decimal), new object());
			Types.Add(typeof(double), new object());
			Types.Add(typeof(float), new object());
			Types.Add(typeof(int), new object());
			Types.Add(typeof(long), new object());
			Types.Add(typeof(sbyte), new object());
			Types.Add(typeof(short), new object());
			Types.Add(typeof(uint), new object());
			Types.Add(typeof(ulong), new object());
			Types.Add(typeof(ushort), new object());
			Types.Add(typeof(bool?), new object());
			Types.Add(typeof(byte?), new object());
			Types.Add(typeof(char?), new object());
			Types.Add(typeof(DateTime?), new object());
			Types.Add(typeof(decimal?), new object());
			Types.Add(typeof(double?), new object());
			Types.Add(typeof(float?), new object());
			Types.Add(typeof(int?), new object());
			Types.Add(typeof(long?), new object());
			Types.Add(typeof(sbyte?), new object());
			Types.Add(typeof(short?), new object());
			Types.Add(typeof(uint?), new object());
			Types.Add(typeof(ulong?), new object());
			Types.Add(typeof(ushort?), new object());

			Types.Add(typeof(string), new object());


		}

		public object this[Type type]
		{
			get
			{
				if(!Types.ContainsKey(type))
					throw new ArgumentException(string.Format("The type specified, ({0}) is not supported.", type));

				return Types[type];
			}
		}
	}
}
