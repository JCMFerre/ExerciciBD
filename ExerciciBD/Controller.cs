using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    public abstract class Controller<T>
    {

        private MySqlConnection connection;

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

    }
}
