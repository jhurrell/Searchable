using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using SearchBuilder.Operators;
using System;
using System.Linq;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class AddOperatorTests
	{
		[TestMethod]
		public void Resets_Collection()
		{
			var target = new AddOperatorSingle()["StringProperty"];
			Assert.AreEqual(1, target.Operators.Count);
		}

		[TestMethod]
		public void Adds_Operator_To_Collection()
		{
			var target = new AddOperatorSingle()["StringProperty"];
			var expected = new string[] { "BeginsWith" };
			var actual = target.Operators.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void Does_Not_Reset_Additional_Properties()
		{
			var target = new AddOperatorMultiple()["StringProperty"];
			var expected = new string[] { "BeginsWith", "Between" };
			var actual = target.Operators.Select(p => p.Name).OrderBy(n => n).ToArray();

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Can_Only_Add_Property_Once()
		{
			var target = new AddOperatorDuplicate();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Cannot_Add_Unsupported()
		{
			var target = new AddOperatorUnsupported();
		}
	}

	public class AddOperatorSingle : SearchBuilder<SampleClass>
	{
		public AddOperatorSingle()
		{
			AddProperty(p => p.StringProperty)
				.AddOperator(Operator.BeginsWith);
		}
	}

	public class AddOperatorMultiple : SearchBuilder<SampleClass>
	{
		public AddOperatorMultiple()
		{
			AddProperty(p => p.StringProperty)
				.AddOperator(Operator.BeginsWith)
				.AddOperator(Operator.Between);
		}
	}

	public class AddOperatorDuplicate : SearchBuilder<SampleClass>
	{
		public AddOperatorDuplicate()
		{
			AddProperty(p => p.StringProperty)
				.AddOperator(Operator.BeginsWith)
				.AddOperator(Operator.BeginsWith);
		}
	}

	public class AddOperatorUnsupported : SearchBuilder<SampleClass>
	{
		public AddOperatorUnsupported()
		{
			AddProperty(p => p.IntProperty)
				.AddOperator(Operator.ContainsAllOf);
		}
	}
}
