using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMarjorie.models
{
    public class Peticion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Estudiante Estudiante { get; set; } // Contiene tanto el CIF como el nombre del estudiante
        public List<Clase> ClasesSeleccionadas { get; set; } // Lista de clases asociadas a la petición
        public byte[] Imagen { get; set; } // La imagen de la solicitud (constancia médica)
    }

}
