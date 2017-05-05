using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciBD
{
    public partial class FormAlumno : Form
    {

        private Controller<Alumno> controller;
        private OnRefreshTable onRefresh;

        public FormAlumno(OnRefreshTable onRefresh)
        {
            InitializeComponent();
            controller = new AlumneController();
            this.onRefresh = onRefresh;
        }

        private void btnCercar_Click(object sender, EventArgs e)
        {
            cargarAlumnoUI(controller.get(tbCercar.Text));
        }

        private void cargarAlumnoUI(Alumno alumno)
        {
            if (alumno != null)
            {
                tbID.Text = alumno.Id.ToString();
                tbNom.Text = alumno.Nom;
                tbCognom.Text = alumno.Cognom;
                tbMail.Text = alumno.Mail;
                tbNIF.Text = alumno.Nif;
                tbTelefon.Text = alumno.Telefon;
                dateTimePicker.Value = DateTime.Parse(alumno.DataNaixement);
                btnAfegir.Enabled = false;
                btnActualitzar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No s'ha trobat cap Alumne amb aquest ID.");
            }
        }

        private void afegirEvent(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool inserit = controller.add(getAlumneUI(false));
                if (inserit)
                {
                    onRefresh.onLoadTable();
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((inserit ? "S'ha " :
                "No s'ha ") + "inserit correctament.");
            }
        }

        private Alumno getAlumneUI(bool cogerID)
        {
            return new Alumno(cogerID ? Convert.ToInt32(tbID.Text) : -33, tbNom.Text, tbCognom.Text, tbNIF.Text,
            tbTelefon.Text, tbMail.Text, dateTimePicker.Value.ToString("yyyy-MM-dd"));
        }

        private bool comprovarCamps()
        {
            return true;
        }

        private void btnNetejarCamps_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbNom.Text = "";
            tbCognom.Text = "";
            tbMail.Text = "";
            tbNIF.Text = "";
            tbTelefon.Text = "";
            tbCercar.Text = "";
            btnAfegir.Enabled = true;
            btnActualitzar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void actualitzarEvent(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool update = controller.update(getAlumneUI(true));
                if (update)
                {
                    onRefresh.onLoadTable();
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((update ? "S'ha " :
                "No s'ha ") + "actualitzat correctament.");
            }
        }

        private void eliminarEvent(object sender, EventArgs e)
        {
            bool esborrat = controller.delete(getAlumneUI(true));
            if (esborrat)
            {
                onRefresh.onLoadTable();
                btnNetejarCamps_Click(null, null);
            }
            MessageBox.Show((esborrat ? "S'ha " :
                "No s'ha ") + "eliminat correctament.");
        }
    }
}