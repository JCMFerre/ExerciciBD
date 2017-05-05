namespace ExerciciBD
{
    partial class FormCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCercar = new System.Windows.Forms.Button();
            this.tbCercar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnNetejarCamps = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCercar
            // 
            this.btnCercar.Location = new System.Drawing.Point(157, 144);
            this.btnCercar.Name = "btnCercar";
            this.btnCercar.Size = new System.Drawing.Size(88, 23);
            this.btnCercar.TabIndex = 6;
            this.btnCercar.Text = "Cercar";
            this.btnCercar.UseVisualStyleBackColor = true;
            this.btnCercar.Click += new System.EventHandler(this.btnCercar_Click);
            // 
            // tbCercar
            // 
            this.tbCercar.Location = new System.Drawing.Point(85, 147);
            this.tbCercar.Name = "tbCercar";
            this.tbCercar.Size = new System.Drawing.Size(66, 20);
            this.tbCercar.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cercar per ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(15, 25);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(75, 20);
            this.tbID.TabIndex = 27;
            // 
            // btnNetejarCamps
            // 
            this.btnNetejarCamps.Location = new System.Drawing.Point(15, 105);
            this.btnNetejarCamps.Name = "btnNetejarCamps";
            this.btnNetejarCamps.Size = new System.Drawing.Size(230, 23);
            this.btnNetejarCamps.TabIndex = 4;
            this.btnNetejarCamps.Text = "Netejar camps";
            this.btnNetejarCamps.UseVisualStyleBackColor = true;
            this.btnNetejarCamps.Click += new System.EventHandler(this.btnNetejarCamps_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(169, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Enabled = false;
            this.btnActualitzar.Location = new System.Drawing.Point(96, 76);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(67, 23);
            this.btnActualitzar.TabIndex = 2;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(15, 76);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(75, 23);
            this.btnAfegir.TabIndex = 1;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.afegirEvent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Accions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(96, 25);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(149, 20);
            this.tbNom.TabIndex = 0;
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 180);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNetejarCamps);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCercar);
            this.Controls.Add(this.tbCercar);
            this.Controls.Add(this.label9);
            this.Name = "FormCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCercar;
        private System.Windows.Forms.TextBox tbCercar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnNetejarCamps;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNom;
    }
}