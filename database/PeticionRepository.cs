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

        private int ObtenerIdClasePorNombre(string nombreClase)
        {
            string sql = "SELECT IdClase FROM Clases WHERE Nombre = @nombreClase";
            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreClase", nombreClase);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void InsertarPeticion(Peticion peticion)
        {
            foreach (var clase in peticion.ClasesSeleccionadas)
            {
                string sql = "INSERT INTO Peticiones (Fecha, NombreClase, CifEstudiante, Imagen) VALUES (@fecha, @nombreClase, @cifEstudiante, @imagen)";

                using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
                {
                    conexion.Open();
                    using (var cmd = new SQLiteCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fecha", peticion.Fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@nombreClase", clase.Nombre);  // Usar el Nombre de la clase
                        cmd.Parameters.AddWithValue("@cifEstudiante", peticion.Estudiante.Cif);
                        cmd.Parameters.AddWithValue("@imagen", peticion.Imagen);  // Insertar la imagen como un arreglo de bytes
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Peticion> ObtenerPeticiones()
        {
            string sql = @"
        SELECT p.IdPeticion, p.Fecha, p.CifEstudiante, p.NombreClase, p.Imagen, c.Nombre AS ClaseNombre, c.NombreProfesor, c.CorreoProfesor, e.Nombre AS EstudianteNombre 
        FROM Peticiones p
        INNER JOIN Clases c ON p.NombreClase = c.Nombre  -- Unir por el Nombre de la Clase
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
                        // Buscar si ya existe una petición en la lista
                        var peticionExistente = peticiones.FirstOrDefault(p => p.Id == Convert.ToInt32(reader["IdPeticion"]));

                        // Depuración, imprime el resultado de FirstOrDefault
                        Console.WriteLine(peticionExistente); // Verifica si es null o no

                        if (peticionExistente == null)
                        {
                            // Si no existe, crear una nueva petición
                            peticionExistente = new Peticion
                            {
                                Id = Convert.ToInt32(reader["IdPeticion"]),
                                Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                                Estudiante = new Estudiante
                                {
                                    Cif = Convert.ToInt32(reader["CifEstudiante"]),
                                    Nombre = reader["EstudianteNombre"].ToString()
                                },
                                ClasesSeleccionadas = new List<Clase>(),
                                Imagen = reader["Imagen"] as byte[]  // Obtener la imagen como byte array
                            };
                            peticiones.Add(peticionExistente);
                        }

                        // Agregar la clase a la lista de clases de la petición
                        peticionExistente.ClasesSeleccionadas.Add(new Clase
                        {
                            Nombre = reader["ClaseNombre"].ToString(),
                            NombreProfesor = reader["NombreProfesor"].ToString(),
                            CorreoProfesor = reader["CorreoProfesor"].ToString()
                        });
                    }
                }
            }

            return peticiones;
        }



        // Eliminar una petición
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
