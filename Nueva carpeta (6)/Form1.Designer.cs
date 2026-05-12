namespace RegistroDEclientes
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
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ID = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(462, 243);
            dataGridView1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(83, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 324);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(602, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(602, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(602, 248);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 102);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 164);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(500, 248);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 11;
            label4.Text = "Correo";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(504, 47);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 12;
            ID.Text = "lD";
            // 
            // txtId
            // 
            txtId.Location = new Point(602, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(ID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label ID;
        private TextBox txtId;
    }
}
