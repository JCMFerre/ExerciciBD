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
    public partial class FormCurso : Form
    {

        private Controller<Curso> controller;
        private OnRefreshTable onRefreshTable;

        public FormCurso(OnRefreshTable onRefreshTable)
        {
            InitializeComponent();
            controller = new CursController();
            this.onRefreshTable = onRefreshTable;
        }

        private void afegirEvent(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool inserit = controller.add(getCursUI(false));
                if (inserit)
                {
                    onRefreshTable.onLoadTable(false);
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((inserit ? "S'ha " :
               "No s'ha ") + "inserit correctament.");
            }
        }

        private Curso getCursUI(bool cogerID)
        {
            return new Curso(cogerID ? Convert.ToInt32(tbID.Text) : -33, tbNom.Text);
        }

        private bool comprovarCamps()
        {
            // Aquí hi aniria la validació dels camps.
            return true;
        }

        private void btnNetejarCamps_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbNom.Text = "";
            tbCercar.Text = "";
            btnAfegir.Enabled = true;
            btnActualitzar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool update = controller.update(getCursUI(true));
                if (update)
                {
                    onRefreshTable.onLoadTable(false);
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((update ? "S'ha " :
                "No s'ha ") + "actualitzat correctament.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool esborrat = controller.delete(getCursUI(true));
            if (esborrat)
            {
                onRefreshTable.onLoadTable(false);
                btnNetejarCamps_Click(null, null);
            }
            MessageBox.Show((esborrat ? "S'ha " :
                "No s'ha ") + "eliminat correctament.");
        }

        private void btnCercar_Click(object sender, EventArgs e)
        {
            cargarCursUI(controller.get(tbCercar.Text));
        }

        private void cargarCursUI(Curso curs)
        {
            if (curs != null)
            {
                tbID.Text = curs.Id.ToString();
                tbNom.Text = curs.Nom;
                btnAfegir.Enabled = false;
                btnActualitzar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
