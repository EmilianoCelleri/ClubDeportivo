using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Socio : Clases.Persona
    {
        //Socio hereda todos los atributos de persona y agrega nro_socio
        public int nro_socio { get; set; }
    }
}
