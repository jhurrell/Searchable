using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searchable;
using System.Linq;
using System.Reflection;

namespace SearchableTests
{
	[TestClass]
	public class ConditionTests
	{
		protected PropertyInfo[] PropertyInfos { get; set; }

		public ConditionTests()
		{
			PropertyInfos = typeof(SampleClass).GetProperties(BindingFlags.Public | BindingFlags.Instance);
		}

		[TestClass]
		public class ConstructorTests : ConditionTests
		{
			public ConstructorTests()
			{

			}

			[TestMethod]
			public void Taking_PropertyInfo()
			{
				var condition = new Condition(PropertyInfos[0]);
				Assert.AreEqual(PropertyInfos[0], condition.PropertyInfo);
				Assert.AreEqual(PropertyInfos[0].Name, condition.DisplayName);
			}

			[TestMethod]
			public void Taking_PropertyInfo_String()
			{
				var condition = new Condition(PropertyInfos[0], "A Totally Different Name");
				Assert.AreEqual(PropertyInfos[0], condition.PropertyInfo);
				Assert.AreEqual("A Totally Different Name", condition.DisplayName);
			}
		}

		[TestClass]
		public class PropertyInfoTests : ConditionTests
		{
			protected PropertyInfo PropertyInfo { get; set; }

			public PropertyInfoTests()
			{
				PropertyInfo = typeof(Condition)
					.GetProperties()
					.Where(p => p.Name == "PropertyInfo")
					.First(); 
			}

			[TestMethod]
			public void Type()
			{
				Assert.AreEqual(PropertyInfo.PropertyType, typeof(PropertyInfo));
			}

			[TestMethod]
			public void Getter_Is_Public()
			{
				Assert.IsTrue(PropertyInfo.GetMethod.IsPublic);
			}

			[TestMethod]
			public void Setter_Is_Private()
			{
				Assert.IsTrue(PropertyInfo.SetMethod.IsPrivate);
			}
		}

		[TestClass]
		public class DisplayNameTests : ConditionTests
		{
			protected PropertyInfo PropertyInfo { get; set; }

			public DisplayNameTests()
			{
				PropertyInfo = typeof(Condition)
					.GetProperties()
					.Where(p => p.Name == "DisplayName")
					.First(); 
			}

			[TestMethod]
			public void Type()
			{
				Assert.AreEqual(PropertyInfo.PropertyType, typeof(string));
			}

			[TestMethod]
			public void Getter_Is_Public()
			{
				Assert.IsTrue(PropertyInfo.GetMethod.IsPublic);
			}

			[TestMethod]
			public void Setter_Is_Private()
			{
				Assert.IsTrue(PropertyInfo.SetMethod.IsPrivate);
			}
		}
	}
}
