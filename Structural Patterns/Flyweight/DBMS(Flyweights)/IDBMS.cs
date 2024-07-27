namespace Flyweight;

interface IDBMS {
	public string DatabaseType { get; }
	public bool IsTrustedConnection { get; }
	public void Connect(Connection connectionObj);
}