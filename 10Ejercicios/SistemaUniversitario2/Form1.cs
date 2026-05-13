using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversitario2.Data;
using SistemaUniversitario2.Datos;
using SistemaUniversitario2.Models;
using System.Data.Entity;


namespace SistemaUniversitario2
{
    public partial class Form1: Form

    {
        UniversidadContext db = new UniversidadContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCarreras();

            MostrarEstudiantes();

        }

        private void CargarCarreras()
        {
            cbCarrera.DataSource = db.Carreras.ToList();
            cbCarrera.DisplayMember = "NombreCarrera";
            cbCarrera.ValueMember = "Id";

            cbFiltroCarrera.DataSource = db.Carreras.ToList();
            cbFiltroCarrera.DisplayMember = "NombreCarrera";
            cbFiltroCarrera.ValueMember = "Id";
        }

        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Ingrese una carrera");
                return;
            }

            Carrera carrera = new Carrera();

            carrera.NombreCarrera = txtCarrera.Text;

            db.Carreras.Add(carrera);

            db.SaveChanges();

            MessageBox.Show("Carrera guardada");

            txtCarrera.Clear();

            CargarCarreras();
        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Estudiante estudiante = new Estudiante();

            estudiante.Nombre = txtNombre.Text;

            estudiante.Edad = int.Parse(txtEdad.Text);

            estudiante.CarreraId = (int)cbCarrera.SelectedValue;

            db.Estudiantes.Add(estudiante);

            db.SaveChanges();

            MessageBox.Show("Estudiante guardado");

            txtNombre.Clear();
            txtEdad.Clear();

            MostrarEstudiantes();
        }

        private void MostrarEstudiantes()
        {
            dgvEstudiantes.DataSource = db.Estudiantes
                .Include(x => x.Carrera)
                .Select(x => new
                {
                    x.Id,
                    x.Nombre,
                    x.Edad,
                    Carrera = x.Carrera.NombreCarrera
                })
                .ToList();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int carreraId = (int)cbFiltroCarrera.SelectedValue;

            dgvEstudiantes.DataSource = db.Estudiantes
                .Include(x => x.Carrera)
                .Where(x => x.CarreraId == carreraId)
                .Select(x => new
                {
                    x.Id,
                    x.Nombre,
                    x.Edad,
                    Carrera = x.Carrera.NombreCarrera
                })
                .ToList();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
