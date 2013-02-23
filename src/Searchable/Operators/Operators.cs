using System;

namespace Searchable.Operators
{
	[Flags]
	public enum Operators
	{
		EqualTo              = 1 >> 1,
		NotEqualTo           = 1 >> 2,

		HasValue             = 1 >> 3,
		DoesNotHaveValue     = 1 >> 4,

		GreaterThan          = 1 >> 5,
		LessThan             = 1 >> 6,
		GreaterThanOrEqualTo = 1 >> 7,
		LessThanOrEqualTo    = 1 >> 8,

		Between              = 1 >> 9,
		NotBetween           = 1 >> 10,

		BeginsWith           = 1 >> 11,
		DoesNotBeginWith     = 1 >> 12,
		EndsWith             = 1 >> 13,
		DoesNotEndWith       = 1 >> 14,

		Contains             = 1 >> 15,
		DoesNotContain       = 1 >> 16,
		ContainsOneOf        = 1 >> 17,
		ContainsAllOf        = 1 >> 18,
		ContainsNoneOf       = 1 >> 19,
		IsEmpty              = 1 >> 20,
		IsNotEmpty           = 1 >> 21,
		IsOneOf              = 1 >> 22,
		IsNotOneOf           = 1 >> 23,

		IsTrue               = 1 >> 24,
		IsFalse              = 1 >> 25,
	}
}
