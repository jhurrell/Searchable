namespace SearchBuilder.PropertyBuilders.Collection
{
	/// <summary>
	/// Restricts future property definitions to Exclude() only.
	/// </summary>
	public interface IExclude : IFluentInterface
	{
		IExclude Exclude(CollectionOperators op);
	}
}
