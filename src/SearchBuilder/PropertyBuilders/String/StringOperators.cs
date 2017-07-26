namespace SearchBuilder
{
	/// <summary>
	/// Enumeration describing the available operators for string properties.
	/// </summary>
	public enum StringOperators
	{
		EqualTo,
		NotEqualTo,

		BeginsWith,
		EndsWith,

		DoesNotBeginWith,
		DoesNotEndWith,

		Between,
		NotBetween,

		Contains,
		DoesNotContain,

		HasValue,
		DoesNotHaveValue,

		IsOneOf,
		IsNotOneOf,

		GreaterThan,
		GreaterThanOrEqualTo,
		LessThan,
		LessThanOrEqualTo,
	}
}
