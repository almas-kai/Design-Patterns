namespace Flyweight;

class Program
{
    static void Main()
    {
        Connection connection = new Connection("sa", "strong_password");
        for(int i = 0; i < 100; i ++){
            IDBMS DBMS = FlyweightFactory.GetDBMS("Internal", true);
            DBMS.Connect(connection);
        }
    }
}
