using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ControlDEinventario.Sqlconexion
{
    public class Conexion
    {
        private string cadena = "Server=localhost\\SQLEXPRESS01;Database=InventarioDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
