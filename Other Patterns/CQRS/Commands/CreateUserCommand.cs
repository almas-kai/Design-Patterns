namespace CQRS;

internal record CreateUserCommand(string Name) : ICommand<Guid>;

internal class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid>
{
	private readonly DatabaseFake _db;
	public CreateUserCommandHandler(DatabaseFake db)
	{
		_db = db;
	}
	public Guid Handle(CreateUserCommand command)
	{
		var id = Guid.NewGuid();
		_db.AddUser(id, command.Name);
		return id;
	}
}