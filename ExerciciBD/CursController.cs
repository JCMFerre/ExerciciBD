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

        public override bool add(Curso objecte)
        {
            return execNonQuery(getCommand(false, true, "INSERT INTO cursos VALUES (null, ?cursosNom)", objecte));
        }

        public override bool delete(Curso objecte)
        {
            return execNonQuery(getCommand(true, false, "DELETE FROM cursos WHERE idCursos = ?idCursos", objecte));
        }

        public override Curso get(object primaryKey)
        {
            Curso curs = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM cursos WHERE idCursos=?idCursos", connection);
            command.Parameters.AddWithValue("?idCursos", primaryKey.ToString());
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    curs = new Curso(reader.GetInt32(0), getString(1, reader));
                }
            }
            connection.Close();
            return curs;

        }

        public override bool update(Curso objecte)
        {
            return execNonQuery(getCommand(true, true, "UPDATE cursos SET cursosNom = ?cursosNom WHERE idCursos = ?idCursos", objecte));
        }

        private MySqlCommand getCommand(bool incluirID, bool incluirResto, string cmd, Curso curso)
        {
            MySqlCommand command = new MySqlCommand(cmd, connection);
            if (incluirID)
            {
                command.Parameters.AddWithValue("?idCursos", curso.Id);
            }
            if (incluirResto)
            {
                command.Parameters.AddWithValue("?cursosNom", string.IsNullOrEmpty(curso.Nom) ? null : curso.Nom);
            }
            return command;
        }
    }
}
