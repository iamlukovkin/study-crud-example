namespace Connector;

public static class ConnectionFactory
{
    public static string Host { get; set; } = "127.0.0.1";
    public static int Port { get; set; } = 5432;
    public static string? Database { get; set; } = "postgres";
    public static string? Username { get; set; } = "postgres";
    public static string Password { get; set; } = "postgres";

    public static string CreateConnectionString()
    {
        if (Host == null || Database == null || Username == null || Password == null)
        {
            throw new ArgumentException("Check properties for connection credentials");
        }
        return $"Host={Host};" +
                                    $"Port={Port};" +
                                    $"Database={Database};" +
                                    $"User Id={Username};" +
                                    $"Password={Password};";
    }
    
}