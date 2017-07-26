namespace SearchBuilder.PropertyBuilders.String
{
	/// <summary>
	/// Restricts future property definitions to Include() only.
	/// </summary>
	public interface IInclude : IFluentInterface
	{
		IInclude Include(StringOperators op);
	}
}
