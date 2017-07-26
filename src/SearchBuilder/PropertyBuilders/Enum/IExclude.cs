namespace SearchBuilder.PropertyBuilders.Enum
{
	/// <summary>
	/// Restricts future property definitions to Exclude() only.
	/// </summary>
	public interface IExclude : IFluentInterface
	{
		IExclude Exclude(EnumOperators op);
	}
}
