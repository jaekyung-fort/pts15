namespace SistemaDeproductos
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
            dgvProductos = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(107, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(656, 273);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 311);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(292, 311);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(508, 311);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(765, 308);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 312);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 315);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 315);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(694, 311);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 8;
            label4.Text = "Stock";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(109, 377);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(265, 377);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(421, 377);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(578, 377);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}
