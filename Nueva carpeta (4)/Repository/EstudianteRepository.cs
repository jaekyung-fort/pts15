using GestionEStudiantes.Entidades;
using SistemaDeproductos.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionEStudiantes.Repository
{
    public class EstudianteRepository
    {
        Conexion con = new Conexion();
        public void Insertar(Estudiante e)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Estudiantes (Nombre,Carrera,Promedio) VALUES (@Nombre,@Carrera,@Promedio)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                cmd.Parameters.AddWithValue("@Carrera", e.Carrera);
                cmd.Parameters.AddWithValue("@Promedio", e.Promedio);

                cmd.ExecuteNonQuery();
            }
        }


        public List<Estudiante> ListarOrdenados()
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Estudiantes", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Estudiante
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Carrera = dr["Carrera"].ToString(),
                        Promedio = (decimal)dr["Promedio"]
                    });
                }
            }
            return lista.OrderByDescending(x => x.Promedio).ToList();
        }


        public List<Estudiante> BuscarPorCarrera(string carrera)
        {
            return ListarOrdenados()
                .Where(x => x.Carrera.ToLower().Contains(carrera.ToLower()))
                .ToList();
        }

        public List<Estudiante> Listar()
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Estudiantes", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Estudiante
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Carrera = dr["Carrera"].ToString(),
                        Promedio = (decimal)dr["Promedio"]
                    });
                }
            }
            return lista;
        }


    }
}