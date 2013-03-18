using System;

namespace SearchBuilder
{
	public interface IProperty
	{
		IProperty DisplayAs(string displayName);
		IProperty WithOperator(Type op);
	}
}
