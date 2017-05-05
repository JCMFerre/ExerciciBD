using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    class AssignaturaController : Controller<Assignatura>
    {

        private bool execNonQuery(MySqlCommand command)
        {
            int numRowsAffected;
            getConnection().Open();
            numRowsAffected = command.ExecuteNonQuery();
            getConnection().Close();
            return numRowsAffected > 0;
        }

        public override bool add(Assignatura objecte)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO assignatures VALUES (null, ?assignaturesNom)", getConnection());
            command.Parameters.AddWithValue("?assignaturesNom", objecte.Nom);
            return execNonQuery(command);
        }

        public override bool delete(Assignatura objecte)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM assignatures WHERE idassignatures = ?idassignatures", getConnection());
            command.Parameters.AddWithValue("?idassignatures", objecte.Id);
            return execNonQuery(command);
        }

        public override Assignatura get(object primaryKey)
        {
            Assignatura assignatura = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM assignatures WHERE idassignatures=?idassignatures", getConnection());
            command.Parameters.AddWithValue("?idassignatures", primaryKey.ToString());
            getConnection().Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    assignatura = new Assignatura(reader.GetInt32(0), reader.GetString(1));
                }
            }
            getConnection().Close();
            return assignatura;
        }

        public override bool update(Assignatura objecte)
        {
            MySqlCommand command = getConnection().CreateCommand();
            command.CommandText = "UPDATE assignatures SET assignaturesNom = ?assignaturesNom WHERE idassignatures = ?idassignatures";
            command.Parameters.AddWithValue("?assignaturesNom", objecte.Nom);
            command.Parameters.AddWithValue("?idassignatures", objecte.Id);
            return execNonQuery(command);
        }
    }
}