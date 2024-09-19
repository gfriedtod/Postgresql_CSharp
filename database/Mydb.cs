using Npgsql;

namespace database;

/*
 * this class help us to config the database connection
 * we use npgsql for the database connection
 */
public class Mydb
{
    private string _database;

    public string Database
    {
        get => _database;
        set => _database = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Host
    {
        get => _host;
        set => _host = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Password
    {
        get => _password;
        set => _password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Port
    {
        get => _port;
        set => _port = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Server
    {
        get => _server;
        set => _server = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string User
    {
        get => _user;
        set => _user = value ?? throw new ArgumentNullException(nameof(value));
    }


    private string _host;
    private string _password;
    private string _port;
    private string _server;
    private string _user;
    private NpgsqlConnection _connection;


    public Mydb(string port, string database, string password, string user, string server)
    {
        _port = port;
        _database = database;
        _password = password;
        _user = user;
        _server = server;
        _connection =
            new NpgsqlConnection(
                "Username=postgres.yrnugzcgcqtxcjvdggti;Password=PV9zI5PEdPBMsJVV;Host=aws-0-eu-central-1.pooler.supabase.com;Port=6543;Database=postgres;");
        // _connection = new NpgsqlConnection("Port=" + _port + ";Database=" + _database +
        //                                   ";Password=" + _password + ";User Id=" + _user + ";Server=" +
        //                                   _server);
        _connection.Open();
        if (_connection.State == System.Data.ConnectionState.Open)
            Console.WriteLine("Success open postgreSQL connection.");
    }

    public NpgsqlConnection Connection
    {
        get => _connection;
        set => _connection = value ?? throw new ArgumentNullException(nameof(value));
    }

    public NpgsqlConnection  connect()
    {
      return  new NpgsqlConnection(
            "Username=postgres.yrnugzcgcqtxcjvdggti;Password=PV9zI5PEdPBMsJVV;Host=aws-0-eu-central-1.pooler.supabase.com;Port=6543;Database=postgres;");
    }

}