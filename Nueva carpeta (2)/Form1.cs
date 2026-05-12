using SistemaDEbiblioteca6.Entidades;
using SistemaDEbiblioteca6.Repository;

namespace SistemaDEbiblioteca6
{
    public partial class Form1 : Form
    {
        LibroRepository repo = new LibroRepository();
        private void CargarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ListarTodos();
        }
        public Form1()
        {
           
            InitializeComponent();
            CargarTabla();
        }

        private bool ValidarCampos()
        {
            int año;

            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                !int.TryParse(txtAño.Text, out año))
            {
                MessageBox.Show(" Validar campos obligatorios");
                return false;
            }

            return true;
        }




        private void Limpiar()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
            txtBuscarAutor.Clear();
            txtId.Clear();
            chkDisponible.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Libro libro = new Libro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                AñoPublicacion = int.Parse(txtAño.Text),
                Disponible = chkDisponible.Checked
            };
            repo.Guardar(libro);
            MessageBox.Show(" Guardado");
            CargarTabla();
            Limpiar();
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            var lista = repo.Disponibles();

            if (lista.Count == 0)
            {
                MessageBox.Show(" No hay libros disponibles");
            }
            dataGridView1.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarAutor.Text))
            {
                MessageBox.Show(" Campo a bbuscar vacío");
                return;
            }

            dataGridView1.DataSource = repo.BuscarAutor(txtBuscarAutor.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            repo.ActualizarDisponibilidad(id, chkDisponible.Checked);
            MessageBox.Show(" Actualizado");
            CargarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void chkDisponible_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.Disponibles();

        }
    }
}
