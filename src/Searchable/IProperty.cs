using SearchBuilder.Operators;

namespace SearchBuilder
{
	public interface IProperty
	{
		IProperty DisplayAs(string displayName);
		IProperty AddOperator(Operator op);
		IProperty RemoveOperator(Operator op);
	}
}
