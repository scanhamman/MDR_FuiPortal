using Npgsql;
namespace MDR_FuiPortal.Server;

public class Creds : ICreds
{
    private readonly Dictionary<string, Cred> _creds = new Dictionary<string, Cred>();

    public Creds(IConfiguration settings)
    {
        _creds.Add("mdr", new Cred
        {
            host_name = settings["mdr_host"],
            user_name = settings["mdr_user"],
            pass_word = settings["mdr_password"],
            db_name = "mdr"
        }); ;

        _creds.Add("context", new Cred
        {
            host_name = settings["mdr_host"],
            user_name = settings["mdr_user"],
            pass_word = settings["mdr_password"],
            db_name = "context"
        }); 
    }

    public string GetConnectionString(string db_name)
    {
        Cred c = _creds[db_name];
        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = c.host_name,
            Username = c.user_name,
            Password = c.pass_word,
            Database = c.db_name
        };
        return builder.ConnectionString;
    }

    private class Cred
    {
        public string? host_name { get; init; }
        public string? user_name { get; init; }
        public string? pass_word { get; init; }
        public string? db_name { get; init; }
    }
}


