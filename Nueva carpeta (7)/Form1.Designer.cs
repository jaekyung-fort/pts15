namespace SistemaDEventa7
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
            dgvVentas = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProducto = new TextBox();
            txtCliente = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnTotalVenta = new Button();
            btnProductoMasVendido = new Button();
            btnTotalGeneral = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = SystemColors.ActiveCaption;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(56, 37);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(477, 288);
            dgvVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 64);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(742, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 115);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 174);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 236);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 314);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(742, 171);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 7;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(742, 115);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(742, 233);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(742, 298);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 10;
            // 
            // btnTotalVenta
            // 
            btnTotalVenta.Location = new Point(115, 380);
            btnTotalVenta.Name = "btnTotalVenta";
            btnTotalVenta.Size = new Size(153, 29);
            btnTotalVenta.TabIndex = 11;
            btnTotalVenta.Text = "Total de la venta";
            btnTotalVenta.UseVisualStyleBackColor = true;
            btnTotalVenta.Click += btnTotalVenta_Click;
            // 
            // btnProductoMasVendido
            // 
            btnProductoMasVendido.Location = new Point(471, 380);
            btnProductoMasVendido.Name = "btnProductoMasVendido";
            btnProductoMasVendido.Size = new Size(168, 29);
            btnProductoMasVendido.TabIndex = 12;
            btnProductoMasVendido.Text = "Producto mas vendido";
            btnProductoMasVendido.UseVisualStyleBackColor = true;
            btnProductoMasVendido.Click += btnProductoMasVendido_Click;
            // 
            // btnTotalGeneral
            // 
            btnTotalGeneral.Location = new Point(285, 375);
            btnTotalGeneral.Name = "btnTotalGeneral";
            btnTotalGeneral.Size = new Size(165, 39);
            btnTotalGeneral.TabIndex = 13;
            btnTotalGeneral.Text = "total general vendido";
            btnTotalGeneral.UseVisualStyleBackColor = true;
            btnTotalGeneral.Click += btnTotalGeneral_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(664, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(156, 29);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(850, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1016, 498);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnTotalGeneral);
            Controls.Add(btnProductoMasVendido);
            Controls.Add(btnTotalVenta);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCliente);
            Controls.Add(txtProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgvVentas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProducto;
        private TextBox txtCliente;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnTotalVenta;
        private Button btnProductoMasVendido;
        private Button btnTotalGeneral;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}
