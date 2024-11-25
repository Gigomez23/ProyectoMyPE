using ProyectoMarjorie.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoMarjorie.models;

namespace ProyectoMarjorie.database
{
    internal class PeticionRepository
    {
        public void InsertarPeticion(Peticion peticion)
        {
            string sql = "INSERT INTO Peticiones (Fecha, IdClase, CifEstudiante) VALUES (@fecha, @idClase, @cifEstudiante)";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@fecha", peticion.Fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@idClase", peticion.Clase.Nombre); // Suponiendo que se busca por nombre
                    cmd.Parameters.AddWithValue("@cifEstudiante", peticion.Estudiante.Cif);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Peticion> ObtenerPeticiones()
        {
            string sql = @"
                SELECT p.IdPeticion, p.Fecha, c.Nombre AS ClaseNombre, e.Nombre AS EstudianteNombre 
                FROM Peticiones p
                INNER JOIN Clases c ON p.IdClase = c.IdClase
                INNER JOIN Estudiantes e ON p.CifEstudiante = e.Cif";

            var peticiones = new List<Peticion>();

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        peticiones.Add(new Peticion
                        {
                            Id = Convert.ToInt32(reader["IdPeticion"]),
                            Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                            Clase = new Clase { Nombre = reader["ClaseNombre"].ToString() },
                            Estudiante = new Estudiante { Nombre = reader["EstudianteNombre"].ToString() }
                        });
                    }
                }
            }

            return peticiones;
        }

        public void EliminarPeticion(int idPeticion)
        {
            string sql = "DELETE FROM Peticiones WHERE IdPeticion = @idPeticion";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idPeticion", idPeticion);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
    