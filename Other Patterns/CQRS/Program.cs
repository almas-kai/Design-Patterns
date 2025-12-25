namespace CQRS;

class Program
{
	static void Main(string[] args)
	{
		var db = new DatabaseFake();

		var createHandler = new CreateUserCommandHandler(db);
		var userId = createHandler.Handle(new CreateUserCommand("Alice"));

		Console.WriteLine($"A new user is created, it's ID is {userId}.");

		var queryHandler = new GetUserQueryHandler(db);
		var userName = queryHandler.Handle(new GetUserQuery(userId));

		Console.WriteLine($"Username of the user is {userName}.");
    }
}
