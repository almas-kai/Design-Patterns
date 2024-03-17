using Proxy.Models;

namespace Proxy.Database;

/// <summary>
///     Represents a user database.
/// </summary>
/// <remarks>
///     Implements <c cref="DatabaseAbstract{T}">DatabaseAbstract</c>.
/// </remarks>
public class UserDatabase : IDatabase<User>
{
    private static Dictionary<int, User> s_database = new Dictionary<int, User>();

    public User Find(int index)
    {
        if(index < 0){
            throw new ArgumentOutOfRangeException("The index must be a positive number.", nameof(index));
        }
        if(!s_database!.ContainsKey(index)){
            throw new KeyNotFoundException("The DB doesn't contain the specified record.");
        }
        return s_database[index];
    }

    public User Add(int index, User record)
    {
        if(index < 0){
            throw new ArgumentOutOfRangeException(nameof(index), "The index must be a positive number.");
        }
        if(record is null){
            throw new ArgumentNullException(nameof(index), "The record mustn't be null.");
        }
        s_database.Add(index, record);
        return record;
    }
}