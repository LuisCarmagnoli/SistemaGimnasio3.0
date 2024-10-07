using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio
{
    public class Reserva : Clase
    {
        public int IdReserva { get; set; }
        public new int IdClase { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
    }
}
