namespace ExerciciBD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fitxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTots = new System.Windows.Forms.RadioButton();
            this.rbPerID = new System.Windows.Forms.RadioButton();
            this.rbAlumne = new System.Windows.Forms.RadioButton();
            this.rbCurs = new System.Windows.Forms.RadioButton();
            this.rbAssignatura = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnCercar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datosGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitxesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fitxesToolStripMenuItem
            // 
            this.fitxesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.assignaturesToolStripMenuItem});
            this.fitxesToolStripMenuItem.Name = "fitxesToolStripMenuItem";
            this.fitxesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fitxesToolStripMenuItem.Text = "Fitxes";
            // 
            // alumnesToolStripMenuItem
            // 
            this.alumnesToolStripMenuItem.Name = "alumnesToolStripMenuItem";
            this.alumnesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnesToolStripMenuItem.Text = "Alumnes";
            this.alumnesToolStripMenuItem.Click += new System.EventHandler(this.alumnesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // assignaturesToolStripMenuItem
            // 
            this.assignaturesToolStripMenuItem.Name = "assignaturesToolStripMenuItem";
            this.assignaturesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assignaturesToolStripMenuItem.Text = "Assignatures";
            this.assignaturesToolStripMenuItem.Click += new System.EventHandler(this.assignaturesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rbTots
            // 
            this.rbTots.AutoSize = true;
            this.rbTots.Checked = true;
            this.rbTots.Location = new System.Drawing.Point(6, 19);
            this.rbTots.Name = "rbTots";
            this.rbTots.Size = new System.Drawing.Size(46, 17);
            this.rbTots.TabIndex = 2;
            this.rbTots.TabStop = true;
            this.rbTots.Text = "Tots";
            this.rbTots.UseVisualStyleBackColor = true;
            // 
            // rbPerID
            // 
            this.rbPerID.AutoSize = true;
            this.rbPerID.Location = new System.Drawing.Point(63, 19);
            this.rbPerID.Name = "rbPerID";
            this.rbPerID.Size = new System.Drawing.Size(36, 17);
            this.rbPerID.TabIndex = 3;
            this.rbPerID.TabStop = true;
            this.rbPerID.Text = "ID";
            this.rbPerID.UseVisualStyleBackColor = true;
            this.rbPerID.CheckedChanged += new System.EventHandler(this.activarCampoId);
            // 
            // rbAlumne
            // 
            this.rbAlumne.AutoSize = true;
            this.rbAlumne.Checked = true;
            this.rbAlumne.Location = new System.Drawing.Point(6, 19);
            this.rbAlumne.Name = "rbAlumne";
            this.rbAlumne.Size = new System.Drawing.Size(60, 17);
            this.rbAlumne.TabIndex = 5;
            this.rbAlumne.TabStop = true;
            this.rbAlumne.Text = "Alumne";
            this.rbAlumne.UseVisualStyleBackColor = true;
            // 
            // rbCurs
            // 
            this.rbCurs.AutoSize = true;
            this.rbCurs.Location = new System.Drawing.Point(72, 19);
            this.rbCurs.Name = "rbCurs";
            this.rbCurs.Size = new System.Drawing.Size(46, 17);
            this.rbCurs.TabIndex = 6;
            this.rbCurs.Text = "Curs";
            this.rbCurs.UseVisualStyleBackColor = true;
            // 
            // rbAssignatura
            // 
            this.rbAssignatura.AutoSize = true;
            this.rbAssignatura.Location = new System.Drawing.Point(124, 19);
            this.rbAssignatura.Name = "rbAssignatura";
            this.rbAssignatura.Size = new System.Drawing.Size(80, 17);
            this.rbAssignatura.TabIndex = 7;
            this.rbAssignatura.Text = "Assignatura";
            this.rbAssignatura.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(105, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(57, 20);
            this.textBoxID.TabIndex = 8;
            // 
            // btnCercar
            // 
            this.btnCercar.Location = new System.Drawing.Point(168, 18);
            this.btnCercar.Name = "btnCercar";
            this.btnCercar.Size = new System.Drawing.Size(73, 22);
            this.btnCercar.TabIndex = 9;
            this.btnCercar.Text = "Cercar";
            this.btnCercar.UseVisualStyleBackColor = true;
            this.btnCercar.Click += new System.EventHandler(this.cercarEvent);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlumne);
            this.groupBox1.Controls.Add(this.rbCurs);
            this.groupBox1.Controls.Add(this.rbAssignatura);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objecte(s) a cercar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTots);
            this.groupBox2.Controls.Add(this.rbPerID);
            this.groupBox2.Controls.Add(this.btnCercar);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Location = new System.Drawing.Point(230, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cercar (per)";
            // 
            // datosGridView
            // 
            this.datosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosGridView.Location = new System.Drawing.Point(12, 91);
            this.datosGridView.Name = "datosGridView";
            this.datosGridView.Size = new System.Drawing.Size(465, 190);
            this.datosGridView.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.datosGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercici BD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fitxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbTots;
        private System.Windows.Forms.RadioButton rbPerID;
        private System.Windows.Forms.RadioButton rbAlumne;
        private System.Windows.Forms.RadioButton rbCurs;
        private System.Windows.Forms.RadioButton rbAssignatura;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnCercar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datosGridView;
    }
}

