using ControlDEinventario.Sqlconexion;
using Microsoft.Data.SqlClient;
using SistemaDEbiblioteca6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDEbiblioteca6.Repository
{
    public class LibroRepository
    {
        private Conexion con = new Conexion();
        public void Guardar(Libro libro)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Libros (Titulo, Autor, AñoPublicacion, Disponible) VALUES (@Titulo, @Autor, @Año, @Disponible)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                cmd.Parameters.AddWithValue("@Año", libro.AñoPublicacion);
                cmd.Parameters.AddWithValue("@Disponible", libro.Disponible);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Libro> ListarTodos()
        {
            List<Libro> lista = new List<Libro>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Libros", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Libro
                    {
                        Id = (int)dr["Id"],
                        Titulo = dr["Titulo"].ToString(),
                        Autor = dr["Autor"].ToString(),
                        AñoPublicacion = (int)dr["AñoPublicacion"],
                        Disponible = (bool)dr["Disponible"]
                    });
                }
            }
            return lista;
        }

        public List<Libro> BuscarAutor(string autor)
        {
            List<Libro> lista = new List<Libro>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Libros WHERE Autor LIKE @Autor", conn);
                cmd.Parameters.AddWithValue("@Autor", "%" + autor + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Libro
                    {
                        Id = (int)dr["Id"],
                        Titulo = dr["Titulo"].ToString(),
                        Autor = dr["Autor"].ToString(),
                        AñoPublicacion = (int)dr["AñoPublicacion"],
                        Disponible = (bool)dr["Disponible"]
                    });
                }
            }
            return lista;
        }

        public List<Libro> Disponibles()
        {
            List<Libro> lista = new List<Libro>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Libros WHERE Disponible = 1", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Libro
                    {
                        Id = (int)dr["Id"],
                        Titulo = dr["Titulo"].ToString(),
                        Autor = dr["Autor"].ToString(),
                        AñoPublicacion = (int)dr["AñoPublicacion"],
                        Disponible = (bool)dr["Disponible"]
                    });
                }
            }
            return lista;
        }

        public void ActualizarDisponibilidad(int id, bool disponible)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Libros SET Disponible=@Disponible WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Disponible", disponible);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }































    }
}
