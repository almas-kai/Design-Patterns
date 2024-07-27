namespace Flyweight;

static class FlyweightFactory {
	private static List<IDBMS> _DBMSList = new List<IDBMS>();
	public static IDBMS GetDBMS(string databaseType, bool isTrustedConnection){
		IDBMS? DBMS = _DBMSList.FirstOrDefault(dbms => dbms.DatabaseType == databaseType && dbms.IsTrustedConnection == isTrustedConnection);

		if(DBMS is null){
			DBMS = new SqlServer(databaseType, isTrustedConnection);
			_DBMSList.Add(DBMS);
		}

		return DBMS;
	}
}