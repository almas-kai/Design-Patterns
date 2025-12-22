namespace Result;

class Program
{
	static void Main(string[] args)
	{
		Result<string> result = UserService.GetUserById(3)
			.Bind(UserService.EnsureUserIsActive)
			.Map(UserService.GetEmail);

		result.Match(
			(email) => Console.WriteLine("User has been found the email is " + email),
			(error) => Console.WriteLine("Something went wrong. " + error)
		);
    }
}
