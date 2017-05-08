using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ExerciciBD
{
    public abstract class Controller<T>
    {

        protected MySqlConnection connection;
        protected OnConnectionFailed listener;

        public Controller(OnConnectionFailed listener)
        {
            connection = Connection.getConnection();
            this.listener = listener;
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
            try
            {
                connection.Open();
                numRowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException)
            {
                numRowsAffected = 0;
                listener.showMessageError();
            }
            return numRowsAffected > 0;
        }

        protected string getString(int position, MySqlDataReader reader)
        {
            string result;
            try
            {
                result = reader.GetString(position);
            }
            catch (Exception)
            {
                result = "";
            }
            return result;
        }

    }

}
