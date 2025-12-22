public static class UserService
{
	private static List<User> _users = new List<User>();
	static UserService()
	{
		User alex = new User(1, "alex@example.com", true);
		User anna = new User(2, "anna@example.com", true);
		User felix = new User(3, "felix@example.com", false);

		_users.AddRange(alex, anna, felix);
	}
	public static Result<User> GetUserById(int id)
	{
		User? target = _users.Find((user) => user.Id == id);

		if (target is null)
		{
			return Result<User>.Failure("User not found");
		}

		return Result<User>.Success(target);
	}

	public static Result<User> EnsureUserIsActive(User user)
	{
		if (!user.IsActive)
		{
			return Result<User>.Failure("User is inactive");
		}

		return Result<User>.Success(user);
	}

	public static string GetEmail(User user)
	{
		return user.Email;
	}
}