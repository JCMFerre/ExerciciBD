namespace ExerciciBD
{
    partial class FormAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbCognom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNetejarCamps = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCercar = new System.Windows.Forms.TextBox();
            this.btnCercar = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(15, 30);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(46, 20);
            this.tbID.TabIndex = 55;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(67, 30);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(129, 20);
            this.tbNom.TabIndex = 1;
            // 
            // tbCognom
            // 
            this.tbCognom.Location = new System.Drawing.Point(202, 30);
            this.tbCognom.Name = "tbCognom";
            this.tbCognom.Size = new System.Drawing.Size(257, 20);
            this.tbCognom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cognom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIF";
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(15, 74);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(89, 20);
            this.tbNIF.TabIndex = 3;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(110, 74);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(75, 20);
            this.tbTelefon.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(191, 74);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(116, 20);
            this.tbMail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data naixement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Accions";
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(15, 130);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(89, 23);
            this.btnAfegir.TabIndex = 7;
            this.btnAfegir.Text = "Afegir";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.afegirEvent);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Enabled = false;
            this.btnActualitzar.Location = new System.Drawing.Point(110, 130);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(75, 23);
            this.btnActualitzar.TabIndex = 8;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.actualitzarEvent);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(191, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.eliminarEvent);
            // 
            // btnNetejarCamps
            // 
            this.btnNetejarCamps.Location = new System.Drawing.Point(273, 130);
            this.btnNetejarCamps.Name = "btnNetejarCamps";
            this.btnNetejarCamps.Size = new System.Drawing.Size(186, 23);
            this.btnNetejarCamps.TabIndex = 10;
            this.btnNetejarCamps.Text = "Netejar camps";
            this.btnNetejarCamps.UseVisualStyleBackColor = true;
            this.btnNetejarCamps.Click += new System.EventHandler(this.btnNetejarCamps_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cercar per ID";
            // 
            // tbCercar
            // 
            this.tbCercar.Location = new System.Drawing.Point(89, 169);
            this.tbCercar.Name = "tbCercar";
            this.tbCercar.Size = new System.Drawing.Size(234, 20);
            this.tbCercar.TabIndex = 11;
            // 
            // btnCercar
            // 
            this.btnCercar.Location = new System.Drawing.Point(330, 167);
            this.btnCercar.Name = "btnCercar";
            this.btnCercar.Size = new System.Drawing.Size(129, 23);
            this.btnCercar.TabIndex = 12;
            this.btnCercar.Text = "Cercar";
            this.btnCercar.UseVisualStyleBackColor = true;
            this.btnCercar.Click += new System.EventHandler(this.btnCercar_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(313, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 206);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnCercar);
            this.Controls.Add(this.tbCercar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNetejarCamps);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCognom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "FormAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbCognom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNetejarCamps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCercar;
        private System.Windows.Forms.Button btnCercar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}