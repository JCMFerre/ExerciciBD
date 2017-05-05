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

        public override bool add(Alumno objecte)
        {
            return false;
        }

        public override bool update(Alumno objecte)
        {
            return false;
        }

        public override bool delete(Alumno objecte)
        {
            return false;
        }

        public override Alumno get(object primaryKey)
        {
            return null;
        }

    }
}
