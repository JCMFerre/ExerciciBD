using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    class Connection
    {

        private static MySqlConnection connection;
        private static string connectionString;

        public static MySqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(getConnectionString());
            }
            return connection;
        }

        public static string getConnectionString()
        {
            if (connectionString == null)
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.Database = "institut";
                builder.UserID = "root";
                builder.Password = "";
                connectionString = builder.ToString();
            }
            return connectionString;
        }

    }
}
