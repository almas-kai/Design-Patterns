using Proxy.Database;
using Proxy.Models;

namespace Proxy;

/// <summary>
///     Logs every operation performed on the database.
/// </summary>
public class LoggingProxy : IDatabase<User>
{
    private static UserDatabase s_database = new UserDatabase();
    public User Add(int index, User record)
    {
        Console.WriteLine("Adding a record.");
        return s_database.Add(index, record);
    }

    public User Find(int index)
    {
        Console.WriteLine("Searching for the record.");
        return s_database.Find(index);
    }
}