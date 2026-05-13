using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaUniversitario2.Datos
{
    public class ConexionDB
    {
        private string cadena =
        @"Server=(local)\SQLEXPRESS;Database=UniversidadDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(cadena);

            try
            {
                cn.Open();
                MessageBox.Show("Conexión exitosa");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cn;
        }
    }
}