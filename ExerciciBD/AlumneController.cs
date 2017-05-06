using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    class AlumneController : Controller<Alumno>
    {
        public AlumneController(OnConnectionFailed listener) : base(listener)
        {
        }

        public override bool add(Alumno objecte)
        {
            return execNonQuery(getCommand(false, true, "INSERT INTO alumnes VALUES (null, ?alumnesNom, ?alumnesCognom, ?alumnesNif, ?alumnesTelefon, ?alumnesMail, ?alumnesDataNaixement)", objecte));
        }

        public override bool update(Alumno objecte)
        {
            return execNonQuery(getCommand(true, true, "UPDATE alumnes SET alumnesNom = ?alumnesNom, alumnesCognom = ?alumnesCognom, alumnesNif = ?alumnesNif, alumnesTelefon = ?alumnesTelefon, alumnesMail = ?alumnesMail, alumnesDataNaixement = ?alumnesDataNaixement WHERE idalumnes = ?idalumnes", objecte));
        }

        public override bool delete(Alumno objecte)
        {
            return execNonQuery(getCommand(true, false, "DELETE FROM alumnes WHERE idalumnes = ?idalumnes", objecte));
        }

        public override Alumno get(object primaryKey)
        {
            Alumno alumno = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM alumnes WHERE idalumnes=?idalumnes", connection);
                command.Parameters.AddWithValue("?idalumnes", primaryKey.ToString());
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        alumno = new Alumno(reader.GetInt32(0), getString(1, reader),
                         getString(2, reader), getString(3, reader), getString(4, reader),
                          getString(5, reader), getString(6, reader));
                    }
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                listener.showMessageError();
            }
            return alumno;
        }

        private MySqlCommand getCommand(bool incluirId, bool incluirResto, string cmd, Alumno alumno)
        {
            MySqlCommand command = new MySqlCommand(cmd, connection);
            if (incluirId)
            {
                command.Parameters.AddWithValue("?idalumnes", alumno.Id);
            }
            if (incluirResto)
            {
                command.Parameters.AddWithValue("?alumnesNom", string.IsNullOrEmpty(alumno.Nom) ? null : alumno.Nom);
                command.Parameters.AddWithValue("?alumnesCognom", string.IsNullOrEmpty(alumno.Cognom) ? null : alumno.Cognom);
                command.Parameters.AddWithValue("?alumnesNif", string.IsNullOrEmpty(alumno.Nif) ? null : alumno.Nif);
                command.Parameters.AddWithValue("?alumnesTelefon", string.IsNullOrEmpty(alumno.Telefon) ? null : alumno.Telefon);
                command.Parameters.AddWithValue("?alumnesMail", string.IsNullOrEmpty(alumno.Mail) ? null : alumno.Mail);
                command.Parameters.AddWithValue("?alumnesDataNaixement", string.IsNullOrEmpty(alumno.DataNaixement) ? null : alumno.DataNaixement);
            }
            return command;
        }

    }
}
