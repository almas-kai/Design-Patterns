namespace Flyweight;

class Connection
{
	public string Name { get; private set; }
	public string Password { get; private set; }
	public Connection(string name, string password)
	{
		Name = name;
		Password = password;
	}
    public override string ToString()
    {
		return $"{Name}, {Password}";
    }
}