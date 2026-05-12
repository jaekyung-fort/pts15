namespace SistemaDEbiblioteca6
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
            txtId = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAño = new TextBox();
            txtBuscarAutor = new TextBox();
            chkDisponible = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            btnDisponibles = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(431, 248);
            dataGridView1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(631, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(631, 89);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(631, 141);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 27);
            txtAutor.TabIndex = 3;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(631, 187);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(125, 27);
            txtAño.TabIndex = 4;
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.Location = new Point(631, 250);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.Size = new Size(125, 27);
            txtBuscarAutor.TabIndex = 5;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.BackColor = SystemColors.ControlDarkDark;
            chkDisponible.Location = new Point(631, 307);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(112, 24);
            chkDisponible.TabIndex = 6;
            chkDisponible.Text = "DISPONIBLE";
            chkDisponible.UseVisualStyleBackColor = false;
            chkDisponible.CheckedChanged += chkDisponible_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(559, 44);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 7;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GrayText;
            label2.Location = new Point(550, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 8;
            label2.Text = "TITULO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GrayText;
            label3.Location = new Point(541, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "AUTOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GrayText;
            label4.Location = new Point(474, 190);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 10;
            label4.Text = "AÑO DE PUBLICAION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(491, 257);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 11;
            label5.Text = "BUSCAR AUTOR";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(22, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnDisponibles
            // 
            btnDisponibles.Location = new Point(132, 319);
            btnDisponibles.Name = "btnDisponibles";
            btnDisponibles.Size = new Size(94, 29);
            btnDisponibles.TabIndex = 13;
            btnDisponibles.Text = "disponible";
            btnDisponibles.UseVisualStyleBackColor = true;
            btnDisponibles.Click += btnDisponibles_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(241, 319);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(359, 319);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(474, 319);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnDisponibles);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkDisponible);
            Controls.Add(txtBuscarAutor);
            Controls.Add(txtAño);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtId;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAño;
        private TextBox txtBuscarAutor;
        private CheckBox chkDisponible;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardar;
        private Button btnDisponibles;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnLimpiar;
    }
}
