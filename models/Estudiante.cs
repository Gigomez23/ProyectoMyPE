using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMarjorie.models
{
    internal class Estudiante
    {
        public int Cif {  get; set; }
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public List<Clase> Horario = new List<Clase>();

        public void AgregarClase(Clase clase)
        {
            Horario.Add(clase);
        }

        //posible mejora, estructurar el horario para que se mueste en forma de tabla para visualizar de mejor manera el horario. 

    }
}
