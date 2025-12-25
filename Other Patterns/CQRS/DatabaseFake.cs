namespace CQRS;

internal class DatabaseFake
{
    private readonly Dictionary<Guid, string> _users = new();

    public void AddUser(Guid id, string name)
    {
        _users[id] = name;
    }

    public string? GetUser(Guid id)
    {
        return _users.TryGetValue(id, out var name) ? name : null;
    }
}
