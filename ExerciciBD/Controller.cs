using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    public abstract class Controller<T>
    {

        protected MySqlConnection connection;

        public Controller()
        {
            connection = Connection.getConnection();
        }

        public abstract bool add(T objecte);

        public abstract bool update(T objecte);

        public abstract bool delete(T objecte);

        public abstract T get(Object primaryKey);

        protected MySqlConnection getConnection()
        {
            return connection;
        }

        protected bool execNonQuery(MySqlCommand command)
        {
            int numRowsAffected;
            connection.Open();
            numRowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return numRowsAffected > 0;
        }

        protected string getString(int position, MySqlDataReader reader)
        {
            string result;
            try
            {
                result = reader.GetString(position);
            }
            catch (SqlNullValueException)
            {
                result = "";
            }
            return result;
        }

    }
}
