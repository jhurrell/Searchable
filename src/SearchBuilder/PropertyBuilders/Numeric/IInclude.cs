namespace SearchBuilder.PropertyBuilders.Numeric
{
	/// <summary>
	/// Restricts future property definitions to Include() only.
	/// </summary>
	public interface IInclude : IFluentInterface
	{
		IInclude Include(NumericOperators op);
	}
}
