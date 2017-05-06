using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExerciciBD
{
    public partial class FormPrincipal : Form, OnRefreshTable
    {
        public FormPrincipal()
        {
            InitializeComponent();
            onLoadTable(false);
        }

        private void activarCampoId(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = rbTots.Checked;
        }

        private void cercarEvent(object sender, EventArgs e)
        {
            onLoadTable(true);
        }

        private string getCommandUI(bool hacerCasoRadioButton)
        {
            string command = "SELECT * FROM " + (rbAlumne.Checked ? "alumnes" :
                rbCurs.Checked ? "cursos" : "assignatures");
            if (hacerCasoRadioButton && rbPerID.Checked)
            {
                command += " WHERE " + (rbAlumne.Checked ? "idalumnes" :
                rbCurs.Checked ? "idCursos" : "idassignatures") + " = " + textBoxID.Text;
            }
            return command;
        }

        private void CargarTabla(string selectCommand)
        {
            try
            {
                MySqlConnection connection = Connection.getConnection();
                connection.Open();
                DataTable table = new DataTable();
                table.Load(new MySqlCommand(selectCommand, connection).ExecuteReader());
                datosGridView.DataSource = table;
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error, comprova que la BD sigui accessible.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void alumnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbAlumne.Checked = true;
            new FormAlumno(this).ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbCurs.Checked = true;
            new FormCurso(this).ShowDialog();
        }

        private void assignaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbAssignatura.Checked = true;
            new FormAsignatura(this).ShowDialog();
        }

        public void onLoadTable(bool hacerCasoRadioButton)
        {
            string command = getCommandUI(hacerCasoRadioButton);
            CargarTabla(command);
        }

        private void eventoCargarTodos(object sender, EventArgs e)
        {
            onLoadTable(false);
        }

    }
}
