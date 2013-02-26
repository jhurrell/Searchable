﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Searchable
{
	/// <summary>
	/// Initializes a new Searchable class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Searchable<T>
    {
		private Dictionary<string, string> properties { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public Searchable()
		{
			properties = new Dictionary<string, string>();

			// Collect all the properties and determine which ones will be exposed for searching.
			PropertyInfo[] propertyInfos;
			propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			// Add each of the properties to the dictionary.
			properties = propertyInfos.ToDictionary(v => v.Name, v => v.Name);
		}

		/// <summary>
		/// 
		/// </summary>
		public ReadOnlyDictionary<string, string> Properties
		{
			get
			{
				return new ReadOnlyDictionary<string, string>(properties);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		public object CanSearch(Expression<Func<T, object>> expression)
		{
			return null;
		}
    }
}
