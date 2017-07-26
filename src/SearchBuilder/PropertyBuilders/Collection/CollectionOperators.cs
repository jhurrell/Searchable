namespace SearchBuilder
{
	/// <summary>
	/// Enumeration describing the available operators for collection properties.
	/// </summary>
	public enum CollectionOperators
	{
		IsEmpty,
		IsNotEmpty,

		ContainsOneOf,
		ContainsNoneOf,
		ContainsAllOf,
	}
}
