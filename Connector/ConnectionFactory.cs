namespace Connector;

public class ConnectionFactory
{
    private static ConnectionFactory? _instance;
    
    // public string Host { get; set; } = "127.0.0.1";
    // public int Port { get; set; } = 5432;
    // public string? Database { get; set; } = "postgres";
    // public string? Username { get; set; } = "postgres";
    // public string Password { get; set; } = "postgres";
    
    public string Host { get; set; } = "46.254.20.134";
    public int Port { get; set; } = 10543;
    public string? Database { get; set; } = "short_db_session";
    public string? Username { get; set; } = "iamlukovkin";
    public string Password { get; set; } = "Tomoye905";

    private ConnectionFactory() 
    {}

    public static ConnectionFactory GetInstance()
    {
        return _instance ??= new ConnectionFactory();
    }

    public string CreateConnectionString()
    {
        if (Host == null || Database == null || Username == null || Password == null)
            throw new ArgumentException("Check properties for connection credentials");
        return $"Host={Host};" +
               $"Port={Port};" +
               $"Database={Database};" +
               $"User Id={Username};" +
               $"Password={Password};";
    }
}