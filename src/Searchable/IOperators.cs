using SearchBuilder.Operators;

namespace SearchBuilder
{
	public interface IOperations
	{
	}

	public interface IBoolOperations : IOperations
	{
		IBoolOperations Include(BoolOperators op);
		IBoolOperations Exclude(BoolOperators op);
	}

	public interface ICommonOperations : IOperations
	{
		ICommonOperations Include(CommonOperators op);
		ICommonOperations Exclude(CommonOperators op);
	}

	public interface IStringOperations : IOperations
	{
		IStringOperations Include(StringOperators op);
		IStringOperations Exclude(StringOperators op);
	}


	public interface IIEnumerableOperations : IOperations
	{
		IIEnumerableOperations Include(IEnumerableOperators op);
		IIEnumerableOperations Exclude(IEnumerableOperators op);
	}


	public class BoolOperations : IBoolOperations
	{
		public IBoolOperations Include(BoolOperators op)
		{
			return this;
		}

		public IBoolOperations Exclude(BoolOperators op)
		{
			return this;
		}
	}

	public class CommonOperations : ICommonOperations
	{
		public ICommonOperations Include(CommonOperators op)
		{
			return this;
		}

		public ICommonOperations Exclude(CommonOperators op)
		{
			return this;
		}
	}

	public class StringOperations : IStringOperations
	{
		public IStringOperations Include(StringOperators op)
		{
			return this;
		}

		public IStringOperations Exclude(StringOperators op)
		{
			return this;
		}
	}

	public class IEnumerableOperations : IIEnumerableOperations
	{
		public IIEnumerableOperations Include(IEnumerableOperators op)
		{
			return this;
		}

		public IIEnumerableOperations Exclude(IEnumerableOperators op)
		{
			return this;
		}
	}
}
