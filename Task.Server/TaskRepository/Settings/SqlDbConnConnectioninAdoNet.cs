namespace TaskRepository.Settings;

public class SqlDbConnConnectioninAdoNet
{
	private string connectionString;

    public SqlDbConnConnectioninAdoNet(string _ConnectionString)
    {
        ConnectionString = _ConnectionString;
    }

    public string ConnectionString
    {
		get { return connectionString; }
		set { connectionString = value; }
	}
}
