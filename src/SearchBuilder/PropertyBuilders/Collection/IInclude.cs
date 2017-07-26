namespace SearchBuilder.PropertyBuilders.Collection
{
	/// <summary>
	/// Restricts future property definitions to Include() only.
	/// </summary>
	public interface IInclude : IFluentInterface
	{
		IInclude Include(CollectionOperators op);
	}
}
