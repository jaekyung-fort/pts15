using SistemaDeproductos.Entidades;

namespace SistemaDeproductos
{
    public partial class Form1 : Form
    {
        Repository.ProductoRepository repo = new Repository.ProductoRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Campos vacíos");
                return;
            }
            Producto p = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };
            repo.Insertar(p);
            MessageBox.Show("Guardado");
            dgvProductos.DataSource = repo.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
    {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            int id;
            decimal precio;
            int stock;
            if (!int.TryParse(txtId.Text, out id) ||
               !decimal.TryParse(txtPrecio.Text, out precio) ||
               !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Datos inválidos");
                return;
            }
            Producto p = new Producto
            {
                Id = id,
                Nombre = txtNombre.Text,
                Precio = precio,
                Stock = stock
            };
            repo.Actualizar(p);
            dgvProductos.DataSource = repo.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = repo.Buscar(txtNombre.Text);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        
            txtId.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
        }
    }

  }

