using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio
{
    public class Clase
    {
        public int IdClase { get; set; }
        public string NombreClase { get; set; }
        public string NombreInstructor { get; set; }
        public string Dias { get; set; }
        public string Horario { get; set; }
        public int Capacidad { get; set; }
        public int EspaciosDisponibles { get; set; }
    }
}
