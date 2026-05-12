namespace GestionEStudiantes
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
            dgvEstudiantes = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            txtPromedio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            btnMostrar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(67, 12);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(683, 250);
            dgvEstudiantes.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(36, 311);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 310);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(504, 314);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(125, 27);
            txtCarrera.TabIndex = 3;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(734, 311);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(125, 27);
            txtPromedio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 313);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 313);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 317);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Carrera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 317);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "Promedio";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(164, 370);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(307, 370);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(459, 370);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrar);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPromedio);
            Controls.Add(txtCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(dgvEstudiantes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstudiantes;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtPromedio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private Button btnMostrar;
        private Button btnBuscar;
    }
}
