using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;
using System.Collections.Generic;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class IsValidTests
	{
		[TestClass]
		public class MinZeroMaxZeroRequiredTests
		{
			public class Tester : OperatorBase
			{
				public Tester()
				{
					MinValuesRequired = 0;
					MaxValuesRequired = 0;
				}
			}

			[TestMethod]
			public void IsValid_WhenNoValues_IsTrue()
			{
				var theOperator = new Tester();
				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenOneValue_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A" });

				Assert.IsFalse(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenManyValues_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A", "B", "C" } );

				Assert.IsFalse(theOperator.IsValid);
			}
		}

		[TestClass]
		public class MinZeroMaxOneRequiredTests
		{
			public class Tester : OperatorBase
			{
				public Tester()
				{
					MinValuesRequired = 0;
					MaxValuesRequired = 1;
				}
			}

			[TestMethod]
			public void IsValid_WhenNoValues_IsTrue()
			{
				var theOperator = new Tester();
				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenOneValue_IsTrue()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A" });

				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenManyValues_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A", "B", "C" });

				Assert.IsFalse(theOperator.IsValid);
			}
		}

		[TestClass]
		public class MinOneMaxOneRequiredTests
		{
			public class Tester : OperatorBase
			{
				public Tester()
				{
					MinValuesRequired = 1;
					MaxValuesRequired = 1;
				}
			}

			[TestMethod]
			public void IsValid_WhenNoValues_IsFalse()
			{
				var theOperator = new Tester();
				Assert.IsFalse(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenOneValue_IsTrue()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A" });

				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenManyValues_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A", "B", "C" });

				Assert.IsFalse(theOperator.IsValid);
			}
		}

		[TestClass]
		public class MinZeroMaxManyRequiredTests
		{
			public class Tester : OperatorBase
			{
				public Tester()
				{
					MinValuesRequired = 0;
					MaxValuesRequired = int.MaxValue;
				}
			}

			[TestMethod]
			public void IsValid_WhenNoValues_IsTrue()
			{
				var theOperator = new Tester();
				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenOneValue_IsTrue()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A" });

				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenManyValues_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A", "B", "C" });

				Assert.IsTrue(theOperator.IsValid);
			}
		}

		[TestClass]
		public class MinOneMaxManyRequiredTests
		{
			public class Tester : OperatorBase
			{
				public Tester()
				{
					MinValuesRequired = 1;
					MaxValuesRequired = int.MaxValue;
				}
			}

			[TestMethod]
			public void IsValid_WhenNoValues_IsFalse()
			{
				var theOperator = new Tester();
				Assert.IsFalse(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenOneValue_IsTrue()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A" });

				Assert.IsTrue(theOperator.IsValid);
			}

			[TestMethod]
			public void IsValid_WhenManyValues_IsFalse()
			{
				var theOperator = new Tester();
				theOperator.Values.AddRange(new List<object> { "A", "B", "C" });

				Assert.IsTrue(theOperator.IsValid);
			}
		}
	}
}
