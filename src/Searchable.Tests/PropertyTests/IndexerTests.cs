using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchBuilder;

namespace SearchableTests.PropertyTests
{
	[TestClass]
	public class IndexerTests
	{
		protected Property target { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			var builder = new SearchBuilder<SampleClass>();
			target = builder["StringProperty"];
		}

		[TestMethod]
		public void Returns_Operator_When_Exists()
		{
			var op = target["BeginsWith"];
			Assert.IsNotNull(op);
		}

		[TestMethod]
		public void Returns_Null_When_Not_Exists()
		{
			var op = target["DoesNotExist"];
			Assert.IsNull(op);
		}

		[TestMethod]
		public void Returns_Correct_Operator()
		{
			var op = target["BeginsWith"];
			Assert.AreEqual("BeginsWith", op.Name);
		}
	}
}
