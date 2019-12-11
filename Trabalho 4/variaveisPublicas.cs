using MySql.Data.MySqlClient;
public sealed class Session
{

    private static volatile Session instance;
    private static object sync = new object();

    private Session() { }

    public static Session Instance {
        get {
            if (instance == null) {
                lock (sync) {
                    if (instance == null) {
                        instance = new Session();
                    }
                }
            }
            return instance;
        }

    }

    /// <summary>
    /// Propriedade para conexão
    /// </summary>
    public MySqlConnection conexao { get; set; }

}
