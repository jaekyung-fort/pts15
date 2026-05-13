using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaUniversitario2.Models;

namespace SistemaUniversitario2.Data
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext() : base("conexion")
        {

        }

        public DbSet<Carrera> Carreras { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

    }
}
