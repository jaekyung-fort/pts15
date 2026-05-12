using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEStudiantes.Entidades
{
    public  class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public decimal Promedio { get; set; }
    }
}
