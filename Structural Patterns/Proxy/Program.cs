using Proxy.Models;
using Proxy.Database;

namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        UserDatabase userDatabase = new UserDatabase();
        userDatabase.Add(9, new User(name: "Almas", age: 22));
        User user = userDatabase.Find(9);
        userDatabase.Add(1, new User("Alex", 100));
        Console.WriteLine(user);

        LoggingProxy proxy = new LoggingProxy();
        proxy.Add(10, new User(name: "Tyles", age: 88));
        proxy.Find(10);
    }
}
