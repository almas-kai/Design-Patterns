namespace CQRS;

internal record GetUserQuery(Guid id) : IQuery<string?>;

internal class GetUserQueryHandler : IQueryHandler<GetUserQuery, string?>
{
	private readonly DatabaseFake _db;
	public GetUserQueryHandler(DatabaseFake db)
	{
		_db = db;
	}
	public string? Handle(GetUserQuery query)
	{
		return _db.GetUser(query.id);
	}
}