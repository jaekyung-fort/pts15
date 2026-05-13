using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaUniversitario2;

namespace SistemaUniversitario2.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        public string NombreCarrera { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
