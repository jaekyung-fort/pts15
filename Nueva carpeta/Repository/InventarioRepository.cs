using ControlDEinventario.Entidades;
using ControlDEinventario.Sqlconexion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDEinventario.Repository
{
    public  class InventarioRepository
    {
        private Conexion con = new Conexion();
        public void Agregar(Inventario inv)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Inventario (Producto, Categoria, Cantidad, PrecioCompra) VALUES (@Producto, @Categoria, @Cantidad, @Precio)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Producto", inv.Producto);
                cmd.Parameters.AddWithValue("@Categoria", inv.Categoria);
                cmd.Parameters.AddWithValue("@Cantidad", inv.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", inv.PrecioCompra);

                cmd.ExecuteNonQuery();
            }
        }

    
        public List<Inventario> Listar()
        {
            List<Inventario> lista = new List<Inventario>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inventario", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Inventario
                    {
                        Id = (int)dr["Id"],
                        Producto = dr["Producto"].ToString(),
                        Categoria = dr["Categoria"].ToString(),
                        Cantidad = (int)dr["Cantidad"],
                        PrecioCompra = (decimal)dr["PrecioCompra"]
                    });
                }
            }
            return lista;
        }

     
        public List<Inventario> StockBajo()
        {
            return Listar().Where(p => p.Cantidad < 5).ToList();
        }
        public decimal ValorTotal()
        {
            return Listar().Sum(p => p.Cantidad * p.PrecioCompra);
        }
    }
}
