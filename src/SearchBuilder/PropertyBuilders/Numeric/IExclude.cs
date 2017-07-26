namespace SearchBuilder.PropertyBuilders.Numeric
{
	/// <summary>
	/// Restricts future property definitions to Exclude() only.
	/// </summary>
	public interface IExclude : IFluentInterface
	{
		IExclude Exclude(NumericOperators op);
	}
}
