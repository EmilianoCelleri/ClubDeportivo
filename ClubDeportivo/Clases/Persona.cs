using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{

    // Clase abstracta -> No permite instanciar objetos de la clase Persona
    public abstract class Persona
    {
        public string? nombre { get; set; }

        public string? apellido { get; set; }

        public string? direccion { get; set; }
        public int telefono { get; set; }
        public string? email { get; set; }
        public int dni { get; set; }

    }
}
