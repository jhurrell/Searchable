namespace SearchBuilder.Tests
{
	public class SampleClassSearcher : SearchBuilder<SampleClass>
	{
		public SampleClassSearcher()
		{
			CanSearch(x => x.BoolProperty)
				.Include(NumericOperators.Between)
				.Include(NumericOperators.DoesNotHaveValue);

			CanSearch(x => x.EnumProperty)
				.Include(EnumOperators.NotEqualTo);

			CanSearch(x => x.StringProperty)
				.Exclude(StringOperators.Contains);
		}
	}
}
