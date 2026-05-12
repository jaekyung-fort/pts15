using RegistroDEclientes.Entidades;
using RegistroDEclientes.Repitory;

namespace RegistroDEclientes
{
    public partial class Form1 : Form
    {
        string conexion = "server=localhost\\SQLEXPRESS01;Database=UnidadIII;Trusted_Connection=True;";

        private void CargarDatos()
        {
            CLienteRepository repo = new CLienteRepository(conexion);
            dataGridView1.DataSource = repo.ObtenerTodos();
        }



        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("tiene que llenar los campos que salen ahi");
                return;
            }

            Cliente cliente = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            CLienteRepository repo = new CLienteRepository(conexion);
            repo.Guardar(cliente);

            MessageBox.Show("Cliente guardado");

            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                CLienteRepository repo = new CLienteRepository(conexion);
                repo.Eliminar(id);

                MessageBox.Show("Eliminado");

                CargarDatos();
            }
        }
    }







}
