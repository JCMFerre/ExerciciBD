using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    class CursController : Controller<Curso>
    {

        private bool execNonQuery(MySqlCommand command)
        {
            int numRowsAffected;
            getConnection().Open();
            numRowsAffected = command.ExecuteNonQuery();
            getConnection().Close();
            return numRowsAffected > 0;
        }

        public override bool add(Curso objecte)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO cursos VALUES (null, ?cursosNom)", getConnection());
            command.Parameters.AddWithValue("?cursosNom", objecte.Nom);
            return execNonQuery(command);
        }

        public override bool delete(Curso objecte)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM cursos WHERE idCursos = ?idCursos", getConnection());
            command.Parameters.AddWithValue("?idCursos", objecte.Id);
            return execNonQuery(command);
        }

        public override Curso get(object primaryKey)
        {
            Curso curs = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM cursos WHERE idCursos=?idCursos", getConnection());
            command.Parameters.AddWithValue("?idCursos", primaryKey.ToString());
            getConnection().Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    curs = new Curso(reader.GetInt32(0), reader.GetString(1));
                }
            }
            getConnection().Close();
            return curs;

        }

        public override bool update(Curso objecte)
        {
            MySqlCommand command = getConnection().CreateCommand();
            command.CommandText = "UPDATE cursos SET cursosNom = ?cursosNom WHERE idCursos = ?idCursos";
            command.Parameters.AddWithValue("?cursosNom", objecte.Nom);
            command.Parameters.AddWithValue("?idCursos", objecte.Id);
            return execNonQuery(command);
        }
    }
}
