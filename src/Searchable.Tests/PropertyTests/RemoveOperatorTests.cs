using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;
using SearchBuilder.Operators;
using System;
using System.Collections.Generic;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class RemoveOperatorTests
	{
		[TestMethod]
		public void Removes_Operator_From_Collection()
		{
			var target = new RemoveOperatorSingle()["StringProperty"];
			var expected = new List<OperatorBase> 
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
				new BeginsWithOperator(),
				new DoesNotContainOperator(),
				new EndsWithOperator(),
			};

			var actual = target.Operators;

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		public void Does_Not_Reset_Additional_Operators()
		{
			var target = new RemoveOperatorMultiple()["StringProperty"];
			var expected = new List<OperatorBase> 
			{
				new BetweenOperator(),
				new NotEqualToOperator(),
				new DoesNotHaveValueOperator(),
				new GreaterThanOperator(),
				new GreaterThanOrEqualToOperator(),
				new HasValueOperator(),
				new IsNotOneOfOperator(),
				new IsOneOfOperator(),
				new LessThanOperator(),
				new LessThanOrEqualToOperator(),
				new BeginsWithOperator(),
				new DoesNotContainOperator(),
				new EndsWithOperator(),
			};

			var actual = target.Operators;

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Can_Only_Remove_Operator_Once()
		{
			var target = new RemoveOperatorDuplicate();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Cannot_Remove_Unsupported_Operator()
		{
			var target = new RemoveOperatorUnsupported();
		}
	}

	public class RemoveOperatorSingle : SearchBuilder<SampleClass>
	{
		public RemoveOperatorSingle()
		{
			AddProperty(p => p.StringProperty)
				.RemoveOperator(Operator.Contains);
		}
	}

	public class RemoveOperatorMultiple : SearchBuilder<SampleClass>
	{
		public RemoveOperatorMultiple()
		{
			AddProperty(p => p.StringProperty)
				.RemoveOperator(Operator.Contains)
				.RemoveOperator(Operator.EqualTo);
		}
	}

	public class RemoveOperatorDuplicate : SearchBuilder<SampleClass>
	{
		public RemoveOperatorDuplicate()
		{
			AddProperty(p => p.StringProperty)
				.RemoveOperator(Operator.Contains)
				.RemoveOperator(Operator.Contains);
		}
	}

	public class RemoveOperatorUnsupported : SearchBuilder<SampleClass>
	{
		public RemoveOperatorUnsupported()
		{
			AddProperty(p => p.IntProperty)
				.AddOperator(Operator.ContainsAllOf);
		}
	}
}
