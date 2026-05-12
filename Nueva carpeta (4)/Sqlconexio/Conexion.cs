using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaDeproductos.Conexion
{
    public class Conexion
    {
        private string cadena = "Server=localhost\\SQLEXPRESS01;Database=EJERCICIO3;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}