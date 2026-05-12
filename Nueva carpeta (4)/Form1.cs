using GestionEStudiantes.Entidades;
using GestionEStudiantes.Repository;

namespace GestionEStudiantes
{
    public partial class Form1 : Form
    {
        EstudianteRepository repository = new EstudianteRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCarrera.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Campos vacíos");
                return;
            }
            decimal promedio;
            if (!decimal.TryParse(txtPromedio.Text, out promedio))
            {
                MessageBox.Show("Promedio inválido");
                return;
            }
            Estudiante e1 = new Estudiante
            {
                Nombre = txtNombre.Text,
                Carrera = txtCarrera.Text,
                Promedio = promedio
            };
            repository.Insertar(e1);

            MessageBox.Show("Registrado");
            dgvEstudiantes.DataSource = repository.Listar();
        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = repository.ListarOrdenados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = repository.BuscarPorCarrera(txtCarrera.Text);
        }
    }
}
