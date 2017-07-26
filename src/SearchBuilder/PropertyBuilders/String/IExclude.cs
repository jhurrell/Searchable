namespace SearchBuilder.PropertyBuilders.String
{
	/// <summary>
	/// Restricts future property definitions to Exclude() only.
	/// </summary>
	public interface IExclude : IFluentInterface
	{
		IExclude Exclude(StringOperators op);
	}
}
