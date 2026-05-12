using ControlDEinventario.Entidades;
using ControlDEinventario.Repository;

namespace ControlDEinventario
{
    public partial class Form1 : Form
    {
        InventarioRepository repo = new InventarioRepository();
        public Form1()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantidad;
            decimal precio;
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                !int.TryParse(txtCantidad.Text, out cantidad) ||
                !decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Datos inválidos. Verifica los campos.");
                return;
            }
            Inventario inv = new Inventario
            {
                Producto = txtProducto.Text,
                Categoria = txtCategoria.Text,
                Cantidad = cantidad,
                PrecioCompra = precio
            };
            repo.Agregar(inv);
            CargarTabla();
        }

        private void CargarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.Listar();
        }

        private void btnStockBajo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.StockBajo();
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor total: " + repo.ValorTotal());
        }
    }
}
