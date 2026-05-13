namespace SistemaUniversitario2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnGuardarCarrera = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.btnGuardarEstudiante = new System.Windows.Forms.Button();
            this.cbFiltroCarrera = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(89, 19);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 22);
            this.txtCarrera.TabIndex = 1;
            // 
            // btnGuardarCarrera
            // 
            this.btnGuardarCarrera.Location = new System.Drawing.Point(216, 19);
            this.btnGuardarCarrera.Name = "btnGuardarCarrera";
            this.btnGuardarCarrera.Size = new System.Drawing.Size(163, 23);
            this.btnGuardarCarrera.TabIndex = 2;
            this.btnGuardarCarrera.Text = "Guardar Carrera";
            this.btnGuardarCarrera.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(62, 154);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 4;
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(233, 104);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(121, 24);
            this.cbCarrera.TabIndex = 5;
            // 
            // btnGuardarEstudiante
            // 
            this.btnGuardarEstudiante.Location = new System.Drawing.Point(216, 153);
            this.btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            this.btnGuardarEstudiante.Size = new System.Drawing.Size(172, 23);
            this.btnGuardarEstudiante.TabIndex = 6;
            this.btnGuardarEstudiante.Text = "Guardar Estudiante";
            this.btnGuardarEstudiante.UseVisualStyleBackColor = true;
            // 
            // cbFiltroCarrera
            // 
            this.cbFiltroCarrera.FormattingEnabled = true;
            this.cbFiltroCarrera.Location = new System.Drawing.Point(560, 104);
            this.cbFiltroCarrera.Name = "cbFiltroCarrera";
            this.cbFiltroCarrera.Size = new System.Drawing.Size(121, 24);
            this.cbFiltroCarrera.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(570, 152);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(113, 244);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(518, 150);
            this.dgvEstudiantes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbFiltroCarrera);
            this.Controls.Add(this.btnGuardarEstudiante);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardarCarrera);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnGuardarCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Button btnGuardarEstudiante;
        private System.Windows.Forms.ComboBox cbFiltroCarrera;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
    }
}

