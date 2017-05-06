using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    class AssignaturaController : Controller<Assignatura>
    {

        public override bool add(Assignatura objecte)
        {
            return execNonQuery(getCommand(false, true, "INSERT INTO assignatures VALUES (null, ?assignaturesNom)", objecte));
        }

        public override bool delete(Assignatura objecte)
        {
            return execNonQuery(getCommand(true, false, "DELETE FROM assignatures WHERE idassignatures = ?idassignatures", objecte));
        }

        public override Assignatura get(object primaryKey)
        {
            Assignatura assignatura = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM assignatures WHERE idassignatures=?idassignatures", connection);
            command.Parameters.AddWithValue("?idassignatures", primaryKey.ToString());
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    assignatura = new Assignatura(reader.GetInt32(0), getString(1, reader));
                }
            }
            connection.Close();
            return assignatura;
        }

        public override bool update(Assignatura objecte)
        {
            return execNonQuery(getCommand(true, true, "UPDATE assignatures SET assignaturesNom = ?assignaturesNom WHERE idassignatures = ?idassignatures", objecte));
        }

        private MySqlCommand getCommand(bool incluirID, bool incluirResto, string cmd, Assignatura assignatura)
        {
            MySqlCommand command = new MySqlCommand(cmd, connection);
            if (incluirID)
            {
                command.Parameters.AddWithValue("?idassignatures", assignatura.Id);
            }
            if (incluirResto)
            {
                command.Parameters.AddWithValue("?assignaturesNom", string.IsNullOrEmpty(assignatura.Nom) ? null : assignatura.Nom);
            }
            return command;
        }
    }
}