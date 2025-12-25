namespace CQRS;

internal interface IQueryHandler<TQuery, TResult>
	where TQuery : IQuery<TResult>
{
	public TResult Handle(TQuery query);
}