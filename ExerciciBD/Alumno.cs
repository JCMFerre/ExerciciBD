using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciBD
{
    class Alumno
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public string Nif { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string DataNaixement { get; set; }

        public Alumno()
        {
        }

        public Alumno(int Id, string Nom, string Cognom, string Nif, string Telefon, string Mail, string DataNaixement)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Cognom = Cognom;
            this.Nif = Nif;
            this.Telefon = Telefon;
            this.Mail = Mail;
            this.DataNaixement = DataNaixement;
        }

    }
}
