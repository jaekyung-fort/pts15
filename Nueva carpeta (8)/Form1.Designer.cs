namespace SistemaMedico8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPacientes = new DataGridView();
            label1 = new Label();
            btnGuardar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtDiagnostico = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBuscar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnBuscar = new Button();
            btnMayores60 = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(37, 35);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(379, 265);
            dgvPacientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 70);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(567, 63);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(567, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(567, 189);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 5;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(567, 263);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(125, 27);
            txtDiagnostico.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 127);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 196);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 270);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "diagnostico";
            label4.Click += label4_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(567, 328);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 332);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 11;
            label5.Text = "buscar paciente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 127);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 12;
            label6.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 388);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 29);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar paciente";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMayores60
            // 
            btnMayores60.Location = new Point(202, 388);
            btnMayores60.Name = "btnMayores60";
            btnMayores60.Size = new Size(126, 29);
            btnMayores60.TabIndex = 14;
            btnMayores60.Text = "mayores de 60";
            btnMayores60.UseVisualStyleBackColor = true;
            btnMayores60.Click += btnMayores60_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(202, 328);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMayores60);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(dgvPacientes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientes;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtDiagnostico;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBuscar;
        private Label label5;
        private Label label6;
        private Button btnBuscar;
        private Button btnMayores60;
        private Button btnLimpiar;
    }
}
