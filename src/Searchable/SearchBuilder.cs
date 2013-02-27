﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SearchBuilder
{
	/// <summary>
	/// Initializes a new SearchBuilder class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class SearchBuilder<T>
    {
		private Dictionary<string, string> properties { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public SearchBuilder()
		{
			properties = new Dictionary<string, string>();

			// Collect all the properties and determine which ones will be exposed for searching.
			PropertyInfo[] propertyInfos;
			propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			// Add each of the properties to the dictionary.
			properties = propertyInfos.ToDictionary(v => v.Name, v => v.Name);
		}

		public ReadOnlyDictionary<string, string> Properties
		{
			get
			{
				return new ReadOnlyDictionary<string, string>(properties);
			}
		}

		public IStringOperations CanSearch(Expression<Func<T, string>> expression)
		{
			return new StringOperations();
		}

		public ICommonOperations CanSearch(Expression<Func<T, int>> expression)
		{
			return new CommonOperations();
		}
    }
}
