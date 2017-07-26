namespace SearchBuilder.PropertyBuilders.Enum
{
	/// <summary>
	/// Restricts future property definitions to Include() only.
	/// </summary>
	public interface IInclude : IFluentInterface
	{
		IInclude Include(EnumOperators op);
	}
}
