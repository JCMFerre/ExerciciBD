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
    public partial class FormAsignatura : Form
    {

        private Controller<Assignatura> controller;
        private OnRefreshTable onRefreshTable;

        public FormAsignatura(OnRefreshTable onRefreshTable)
        {
            InitializeComponent();
            controller = new AssignaturaController();
            this.onRefreshTable = onRefreshTable;
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

        private void btnCercar_Click(object sender, EventArgs e)
        {
            cargarAssignaturaUI(controller.get(tbCercar.Text));
        }

        private void cargarAssignaturaUI(Assignatura assignatura)
        {
            if (assignatura != null)
            {
                tbID.Text = assignatura.Id.ToString();
                tbNom.Text = assignatura.Nom;
                btnAfegir.Enabled = false;
                btnActualitzar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No s'ha trobat cap assignatura amb aquest ID.");
            }
        }

        private Assignatura getAssignaturaUI(bool cogerId)
        {
            return new Assignatura(cogerId ? Convert.ToInt32(tbID.Text) : -33, tbNom.Text);
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool update = controller.update(getAssignaturaUI(true));
                if (update)
                {
                    onRefreshTable.onLoadTable(false);
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((update ? "S'ha " :
                "No s'ha ") + "actualitzat correctament.");
            }
        }

        private bool comprovarCamps()
        {
            // Aquí hi aniria la validació dels camps.
            return true;
        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            if (comprovarCamps())
            {
                bool inserit = controller.add(getAssignaturaUI(false));
                if (inserit)
                {
                    onRefreshTable.onLoadTable(false);
                    btnNetejarCamps_Click(null, null);
                }
                MessageBox.Show((inserit ? "S'ha " :
                "No s'ha ") + "inserit correctament.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool esborrat = controller.delete(getAssignaturaUI(true));
            if (esborrat)
            {
                onRefreshTable.onLoadTable(false);
                btnNetejarCamps_Click(null, null);
            }
            MessageBox.Show((esborrat ? "S'ha " :
                "No s'ha ") + "eliminat correctament.");
        }
    }
}
