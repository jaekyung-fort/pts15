using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using RegistroDEclientes.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace RegistroDEclientes.Repitory
{
    public class CLienteRepository
    {

        private readonly string conexion;

        public CLienteRepository(string conexion)
        {

            this.conexion = conexion;

        }

        public void Guardar(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "INSERT INTO Clientes (Id,Nombre, Telefono, Correo) VALUES (@Id,@Nombre, @Telefono, @Correo)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", cliente.Id);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

    
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "DELETE FROM Clientes WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }

    }

}
