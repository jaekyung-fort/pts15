namespace ControlDEinventario
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
            txtId = new TextBox();
            label1 = new Label();
            txtProducto = new TextBox();
            txtCategoria = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnStockBajo = new Button();
            btnValorTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(545, 342);
            dataGridView1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 443);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(856, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 74);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(856, 128);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 4;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(856, 189);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(856, 245);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(856, 316);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 135);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 8;
            label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 196);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 9;
            label3.Text = "CATEGORIA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 252);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(701, 323);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 11;
            label5.Text = "PRECIO COMPRA";
            // 
            // btnStockBajo
            // 
            btnStockBajo.Location = new Point(275, 443);
            btnStockBajo.Name = "btnStockBajo";
            btnStockBajo.Size = new Size(134, 29);
            btnStockBajo.TabIndex = 12;
            btnStockBajo.Text = "STOCK BAJO";
            btnStockBajo.UseVisualStyleBackColor = true;
            btnStockBajo.Click += btnStockBajo_Click;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Location = new Point(495, 443);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(139, 29);
            btnValorTotal.TabIndex = 13;
            btnValorTotal.Text = "VALOR TOTAL";
            btnValorTotal.UseVisualStyleBackColor = true;
            btnValorTotal.Click += btnValorTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1098, 588);
            Controls.Add(btnValorTotal);
            Controls.Add(btnStockBajo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtCategoria);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Controls.Add(txtId);
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
        private TextBox txtId;
        private Label label1;
        private TextBox txtProducto;
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnStockBajo;
        private Button btnValorTotal;
    }
}
