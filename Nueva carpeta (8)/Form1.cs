using SistemaMedico8.Entidades;
using SistemaMedico8.Repository;

namespace SistemaMedico8
{
    public partial class Form1 : Form
    {



        PacienteRepository repo = new PacienteRepository();

        private void CargarDatos()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = repo.Listar();
        }




        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            Paciente p = new Paciente
            {
                Nombre = txtNombre.Text,
                Edad = edad,
                Diagnostico = txtDiagnostico.Text
            };

            repo.Guardar(p);
            CargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = repo.BuscarPorNombre(txtBuscar.Text);
        }

        private void btnMayores60_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = repo.MayoresDe60();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
            txtBuscar.Clear();
        }
    }
}
