namespace SearchBuilder
{
	/// <summary>
	/// Enumeration describing the available operators for numeric properties.
	/// </summary>
	public enum NumericOperators
	{
		EqualTo,
		NotEqualTo,

		Between,
		NotBetween,

		IsOneOf,
		IsNotOneOf,

		HasValue,
		DoesNotHaveValue,

		GreaterThan,
		GreaterThanOrEqualTo,

		LessThan,
		LessThanOrEqualTo,
	}
}
