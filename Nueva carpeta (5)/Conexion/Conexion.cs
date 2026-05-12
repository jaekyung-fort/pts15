using Microsoft.EntityFrameworkCore;
using SistemaDeproductos.Entidades;

namespace SistemaDeproductos.Conexion
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=localhost\\SQLEXPRESS01;Database=EJERCICIO2;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
