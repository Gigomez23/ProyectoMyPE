    using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMarjorie.models
{
    public class Estudiante
    {
        public int Cif {  get; set; }
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public List<Clase> Horario = new List<Clase>();

        public void AgregarClase(Clase clase)
        {
            Horario.Add(clase);
        }


        public void EliminarClase(string nombreClase)
        {
            for (int i = 0; i < Horario.Count; i++)
            {
                if (nombreClase == Horario[i].Nombre)
                {
                    Horario.Remove(Horario[i]);
                }
            }
        }

    }
}
