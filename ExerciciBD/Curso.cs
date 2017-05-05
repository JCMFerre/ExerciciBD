using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciBD
{
    class Curso
    {

        public int Id { get; set; }
        public string Nom { get; set; }

        public Curso()
        {
        }

        public Curso(int Id, string Nom)
        {
            this.Id = Id;
            this.Nom = Nom;
        }

    }
}
