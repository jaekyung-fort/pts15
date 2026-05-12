using Microsoft.Data.SqlClient;
using SistemaMedico8.Entidades;
using SistemaMedico8.sqlConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico8.Repository
{
    public class PacienteRepository
    {



        Conexion con = new Conexion();

        public void Guardar(Paciente p)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Pacientes (Nombre, Edad, Diagnostico) VALUES (@Nombre,@Edad,@Diagnostico)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Edad", p.Edad);
                cmd.Parameters.AddWithValue("@Diagnostico", p.Diagnostico);

                cmd.ExecuteNonQuery();
            }
        }

 
        public List<Paciente> Listar()
        {
            List<Paciente> lista = new List<Paciente>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pacientes", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Paciente
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Edad = (int)dr["Edad"],
                        Diagnostico = dr["Diagnostico"].ToString()
                    });
                }
            }
            return lista;
        }

     
        public List<Paciente> BuscarPorNombre(string nombre)
        {
            List<Paciente> lista = new List<Paciente>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Pacientes WHERE Nombre LIKE @Nombre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Paciente
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Edad = (int)dr["Edad"],
                        Diagnostico = dr["Diagnostico"].ToString()
                    });
                }
            }
            return lista;
        }

     
        public List<Paciente> MayoresDe60()
        {
            List<Paciente> lista = new List<Paciente>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Pacientes WHERE Edad > 60";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Paciente
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Edad = (int)dr["Edad"],
                        Diagnostico = dr["Diagnostico"].ToString()
                    });
                }
            }
            return lista;
        }














    }
}
