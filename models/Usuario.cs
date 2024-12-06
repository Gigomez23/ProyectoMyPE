using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMarjorie.models
{
    public class Usuario
    {
        public string nombreUsuario { get; set; }

        public string contrasena { get; set;  }

        public Estudiante Estudiante { get; set; }

    }
}
