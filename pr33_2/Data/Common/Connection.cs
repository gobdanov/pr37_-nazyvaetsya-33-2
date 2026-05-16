using MySql.Data.MySqlClient;

namespace pr33_2.Data.Common
{
    public class Connection
    {
        readonly static string ConnectionData = "server=localhost; port=3306;database=pr38;uid=root;pwd=;";
        public static MySqlConnection MySqlOpen()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.Open();
            return conn;
        }

        public static MySqlDataReader MySqlQuery(string query, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            return command.ExecuteReader();
        }

        public static void MySqlClose(MySqlConnection conn)
        {
            conn.Close();
        }
    }
}
