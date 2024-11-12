using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMarjorie.models
{
    internal class Peticion
    {
        public DateTime Fecha {  get; set; }
        public Clase Clase { get; set; }
        public Estudiante Estudiante { get; set; }

    }
}
