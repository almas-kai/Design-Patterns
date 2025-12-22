 public sealed class User
{
	public int Id { get; }
	public string Email { get; }
	public bool IsActive { get; }

	public User(int id, string email, bool isActive)
	{
		Id = id;
		Email = email;
		IsActive = isActive;
	}
}