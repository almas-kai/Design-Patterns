namespace Flyweight;

class SqlServer : IDBMS
{
	private static int s_InstanceCounter = 0;
	public string DatabaseType { get; private set; }
	public bool IsTrustedConnection { get; private set; }
	public SqlServer(string databaseType, bool isTrustedConnection)
	{
		s_InstanceCounter ++;
		Console.WriteLine($"A new instance was created! Total number of instances {s_InstanceCounter}.");
		DatabaseType = databaseType;
		IsTrustedConnection = isTrustedConnection;
	}

	public void Connect(Connection connectionObj)
	{
		Console.WriteLine($"Connecting to the {DatabaseType} using the {connectionObj}. The connection is {(IsTrustedConnection ? "trusted" : "not trusted")}.");
	}
}