using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder.Operators;

namespace SearchBuilder.Tests.OperatorTests
{
	[TestClass]
	public class OperatorBaseTests
	{
		public class Tester : OperatorBase
		{
			public Tester()
			{
				Name = "Tester";
				Symbol = "Tester";
				MinValuesRequired = 1;
				MaxValuesRequired = 1;
			}
		}

		public class OtherTester : OperatorBase
		{
			public OtherTester()
			{
				Name = "OtherTester";
				Symbol = "OtherTester";
				MinValuesRequired = 1;
				MaxValuesRequired = 1;
			}
		}

		[TestClass]
		public class GetHashCodeTests : OperatorBaseTests
		{
			[TestMethod]
			public void GetHashCode_WhenDifferentTypeAndSameValuesValues_ReturnsDifferentResult()
			{
				var tester = new Tester { Values = new List<object> { "A", "B", "C" } };
				var otherTester = new OtherTester { Values = new List<object> { "A", "B", "C" } };
				Assert.AreNotEqual(tester.GetHashCode(), otherTester.GetHashCode());
			}

			[TestMethod]
			public void GetHashCode_WhenSameTypeAndDifferentValuesValues_ReturnsDifferentResult()
			{
				var testerA = new Tester { Values = new List<object> { "A", "B", "C" } };
				var testerB = new Tester { Values = new List<object> { "A", "B", "Z" } };
				Assert.AreNotEqual(testerA.GetHashCode(), testerB.GetHashCode());
			}

			[TestMethod]
			public void GetHashCode_WhenSameTypeAndSameValuesValues_ReturnsSameResult()
			{
				var testerA = new Tester { Values = new List<object> { "A", "B", "C" } };
				var testerB = new Tester { Values = new List<object> { "A", "B", "C" } };
				Assert.AreEqual(testerA.GetHashCode(), testerB.GetHashCode());
			}
		}

		[TestClass]
		public class EqualsTests : OperatorBaseTests
		{
			[TestMethod]
			public void Equals_WhenOtherIsNull_ReturnsFalse()
			{
				var tester = new Tester();
				Assert.IsFalse(tester.Equals(null));
			}

			[TestMethod]
			public void Equals_WhenOtherIsDifferentType_ReturnsFalse()
			{
				var tester = new Tester();
				Assert.IsFalse(tester.Equals(""));
			}

			[TestMethod]
			public void Equals_WhenOtherIsSelf_ReturnsTrue()
			{
				var tester = new Tester();
				Assert.IsTrue(tester.Equals(tester));
			}

			[TestMethod]
			public void Equals_WhenOtherIsIdentical_ReturnsTrue()
			{
				var tester = new Tester();
				var other = new Tester();
				Assert.IsTrue(tester.Equals(other));
			}

			[TestMethod]
			public void Equals_WhenOtherIsIdenticalDifferentValues_ReturnsFalse()
			{
				var tester = new Tester { Values = new List<object> { "A", "B", "C" } };
				var other = new Tester { Values = new List<object> { "A", "B", "Z" } };
				Assert.IsFalse(tester.Equals(other));
			}

			[TestMethod]
			public void Equals_WhenOtherIsIdenticalSameValues_ReturnsTrue()
			{
				var tester = new Tester { Values = new List<object> { "A", "B", "C" } };
				var other = new Tester { Values = new List<object> { "A", "B", "C" } };
				Assert.IsTrue(tester.Equals(other));
			}
		}
	}
}
