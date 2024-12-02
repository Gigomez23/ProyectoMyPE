using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyectoMarjorie.models
{
    public class DatabaseHelper
    {
        public const string DatabasePath = "Data Source=proyecto_marjorie.sqlite;";

        public static void InicializarBaseDeDatos()
        {
            if (!File.Exists("proyecto_marjorie.sqlite"))
            {
                SQLiteConnection.CreateFile("proyecto_marjorie.sqlite");
                Console.WriteLine("Base de datos creada.");
            }

            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                // Crear las tablas
                string sql = @"
CREATE TABLE IF NOT EXISTS Estudiantes (
    Cif INTEGER PRIMARY KEY,
    Nombre TEXT NOT NULL,
    FechaNacimiento TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS Clases (
    IdClase INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    NombreProfesor TEXT,
    CorreoProfesor TEXT
);

CREATE TABLE IF NOT EXISTS Peticiones (
    IdPeticion INTEGER PRIMARY KEY AUTOINCREMENT,
    Fecha TEXT NOT NULL,
    CifEstudiante INTEGER NOT NULL,
    Imagen BLOB,  -- Agregar la columna para la imagen
    FOREIGN KEY (CifEstudiante) REFERENCES Estudiantes(Cif)
);

CREATE TABLE IF NOT EXISTS ClasesPeticiones (
    IdPeticion INTEGER NOT NULL,
    IdClase INTEGER NOT NULL,
    PRIMARY KEY (IdPeticion, IdClase),
    FOREIGN KEY (IdPeticion) REFERENCES Peticiones(IdPeticion),
    FOREIGN KEY (IdClase) REFERENCES Clases(IdClase)
);

CREATE TABLE IF NOT EXISTS Estudiantes_Clases (
    CifEstudiante INTEGER NOT NULL,
    IdClase INTEGER NOT NULL,
    PRIMARY KEY (CifEstudiante, IdClase),
    FOREIGN KEY (CifEstudiante) REFERENCES Estudiantes(Cif),
    FOREIGN KEY (IdClase) REFERENCES Clases(IdClase)
);

CREATE TABLE IF NOT EXISTS Usuarios (
    nombreUsuario TEXT PRIMARY KEY,
    contrasena TEXT NOT NULL,
    CifEstudiante INTEGER NOT NULL,
    FOREIGN KEY (CifEstudiante) REFERENCES Estudiantes(Cif)
);
";

                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tablas creadas o ya existentes.");
                }
            }
        }




        public static bool AgregarUsuario(string nombreUsuario, string contrasena, string cifEstudiante)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                try
                {
                    conexion.Open();

                    // Validar que el estudiante existe
                    string validarEstudiante = "SELECT Cif FROM Estudiantes WHERE Cif = @Cif";
                    using (var cmd = new SQLiteCommand(validarEstudiante, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Cif", cifEstudiante);
                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("El estudiante no existe.");
                            return false;
                        }
                    }

                    // Insertar en la tabla Usuarios
                    string query = "INSERT INTO Usuarios (nombreUsuario, contrasena, CifEstudiante) VALUES (@nombreUsuario, @contrasena, @CifEstudiante)";
                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@CifEstudiante", cifEstudiante);
                        cmd.ExecuteNonQuery();
                    }

                    return true; // Usuario agregado exitosamente
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar el usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public static Usuario AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                string query = @"
            SELECT Usuarios.nombreUsuario, Usuarios.contrasena, Estudiantes.Cif, Estudiantes.Nombre, Estudiantes.FechaNacimiento
            FROM Usuarios
            INNER JOIN Estudiantes ON Usuarios.CifEstudiante = Estudiantes.Cif
            WHERE Usuarios.nombreUsuario = @nombreUsuario AND Usuarios.contrasena = @contrasena";

                using (var cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                nombreUsuario = reader.GetString(0),
                                contrasena = reader.GetString(1),
                                Estudiante = new Estudiante
                                {
                                    Cif = reader.GetInt32(2),
                                    Nombre = reader.GetString(3),
                                    FechaNacimiento = DateTime.Parse(reader.GetString(4))
                                }
                            };
                        }
                    }
                }
            }
            return null; // Retorna null explícitamente si no se encuentran credenciales válidas
        }


        public static Estudiante ObtenerEstudiantePorCif(string cif)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();
                string query = "SELECT * FROM Estudiantes WHERE Cif = @Cif";

                using (var cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Cif", cif);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Estudiante
                            {
                                Cif = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaNacimiento = reader.GetDateTime(2)
                            };
                        }
                    }
                }
            }
            return null; // Si no encuentra al estudiante
        }

        //public static Estudiante ObtenerEstudiantePorCif(string cif)
        //{
        //    using (var conexion = new SQLiteConnection(DatabasePath))
        //    {
        //        conexion.Open();
        //        string query = "SELECT * FROM Estudiantes WHERE Cif = @Cif";

        //        using (var cmd = new SQLiteCommand(query, conexion))
        //        {
        //            cmd.Parameters.AddWithValue("@Cif", cif);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return new Estudiante
        //                    {
        //                        Cif = reader.GetInt32(0),
        //                        Nombre = reader.GetString(1),
        //                        FechaNacimiento = reader.GetDateTime(2)
        //                    };
        //                }
        //            }
        //        }
        //    }
        //    return null; // Si no encuentra al estudiante
        //}


        public static bool AgregarEstudiante(string nombre, string cif, DateTime fechaNacimiento)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Estudiantes (Nombre, Cif, FechaNacimiento) VALUES (@Nombre, @Cif, @FechaNacimiento)";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Cif", cif);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.ToString("yyyy-MM-dd")); // Formato de fecha
                        cmd.ExecuteNonQuery();
                    }

                    return true; // Si todo salió bien
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false; // Si hubo algún error
                }
            }
        }

        public static bool ActualizarEstudiante(Estudiante estudiante)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                try
                {
                    conexion.Open();

                    // Query SQL para actualizar los datos del estudiante
                    string query = "UPDATE Estudiantes SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento WHERE Cif = @Cif";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        // Usar parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento.ToString("yyyy-MM-dd")); // Convertir fecha al formato correcto
                        cmd.Parameters.AddWithValue("@Cif", estudiante.Cif);

                        // Ejecutar el comando SQL
                        cmd.ExecuteNonQuery();
                    }

                    return true; // Si la actualización fue exitosa
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estudiante: {ex.Message}");
                    return false; // Si ocurrió un error
                }
            }
        }

        public static bool AgregarClaseAEstudiante(string nombre, string nombreProfesor, string correoProfesor)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Clases (Nombre, NombreProfesor, CorreoProfesor) VALUES (@Nombre, @NombreProfesor, @CorreoProfesor)";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@NombreProfesor", nombreProfesor);
                        cmd.Parameters.AddWithValue("@CorreoProfesor", correoProfesor);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la clase: {ex.Message}");
                    return false;
                }
            }
        }


        public static Clase ObtenerClasePorNombre(string nombreClase)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();
                string query = "SELECT Nombre, NombreProfesor, CorreoProfesor FROM Clases WHERE Nombre = @Nombre";

                using (var cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreClase);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Clase
                            {
                                Nombre = reader.GetString(0),
                                NombreProfesor = reader.GetString(1),
                                CorreoProfesor = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return null; // Esto es válido ya que 'Clase' es un tipo de referencia y puede ser 'null'
        }



        public static bool AsignarClaseAEstudiante(int cifEstudiante, string nombreClase)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                // Obtener el IdClase basado en el nombre de la clase
                string queryIdClase = "SELECT IdClase FROM Clases WHERE Nombre = @NombreClase";
                int idClase;

                using (var cmd = new SQLiteCommand(queryIdClase, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreClase", nombreClase);
                    var result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("No se encontró la clase especificada.");
                        return false;
                    }

                    idClase = Convert.ToInt32(result);
                }

                // Insertar la relación en Estudiantes_Clases
                string queryInsert = "INSERT INTO Estudiantes_Clases (CifEstudiante, IdClase) VALUES (@CifEstudiante, @IdClase)";
                using (var cmd = new SQLiteCommand(queryInsert, conexion))
                {
                    cmd.Parameters.AddWithValue("@CifEstudiante", cifEstudiante);
                    cmd.Parameters.AddWithValue("@IdClase", idClase);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al asignar la clase al estudiante: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public static void EliminarClaseDeEstudiante(int cifEstudiante, string nombreClase)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                // Obtener el IdClase por el nombre de la clase
                string sqlGetIdClase = "SELECT IdClase FROM Clases WHERE Nombre = @NombreClase";
                int idClase = -1;

                using (var cmd = new SQLiteCommand(sqlGetIdClase, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreClase", nombreClase);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idClase = reader.GetInt32(0); // Obtener IdClase
                        }
                    }
                }

                // Si no se encuentra la clase, retornar
                if (idClase == -1)
                {
                    MessageBox.Show("La clase no existe.");
                    return;
                }

                // Eliminar la clase del estudiante
                string sqlEliminarClase = "DELETE FROM Estudiantes_Clases WHERE CifEstudiante = @CifEstudiante AND IdClase = @IdClase";

                using (var cmd = new SQLiteCommand(sqlEliminarClase, conexion))
                {
                    cmd.Parameters.AddWithValue("@CifEstudiante", cifEstudiante);
                    cmd.Parameters.AddWithValue("@IdClase", idClase);  // Usamos IdClase para eliminar la relación
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("La clase ha sido eliminada del horario del estudiante.");
            }
        }

        public static List<Clase> ObtenerClasesDeEstudiante(int cifEstudiante)
        {
            List<Clase> clases = new List<Clase>();

            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                string query = @"
            SELECT Clases.Nombre, Clases.NombreProfesor, Clases.CorreoProfesor
            FROM Clases
            INNER JOIN Estudiantes_Clases ON Estudiantes_Clases.IdClase = Clases.IdClase
            WHERE Estudiantes_Clases.CifEstudiante = @CifEstudiante";

                using (var cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@CifEstudiante", cifEstudiante);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clases.Add(new Clase
                            {
                                Nombre = reader.GetString(0),
                                NombreProfesor = reader.GetString(1),
                                CorreoProfesor = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return clases;
        }

        public static bool AgregarPeticion(string nombreClase, string cifEstudiante, DateTime fecha, byte[] imagen)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                try
                {
                    conexion.Open();

                    // Obtener el ID de la clase usando el nombre
                    string queryObtenerClaseId = "SELECT IdClase FROM Clases WHERE Nombre = @NombreClase";
                    int idClase = -1;
                    using (var cmdClaseId = new SQLiteCommand(queryObtenerClaseId, conexion))
                    {
                        cmdClaseId.Parameters.AddWithValue("@NombreClase", nombreClase);
                        using (var reader = cmdClaseId.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idClase = Convert.ToInt32(reader["IdClase"]);
                            }
                            else
                            {
                                MessageBox.Show($"No se encontró la clase con el nombre: {nombreClase}");
                                return false;
                            }
                        }
                    }

                    // Insertar la petición en la tabla principal
                    string queryPeticion = "INSERT INTO Peticiones (CifEstudiante, Fecha, Imagen) VALUES (@CifEstudiante, @Fecha, @Imagen)";
                    using (var cmdPeticion = new SQLiteCommand(queryPeticion, conexion))
                    {
                        cmdPeticion.Parameters.AddWithValue("@CifEstudiante", cifEstudiante);
                        cmdPeticion.Parameters.AddWithValue("@Fecha", fecha);
                        cmdPeticion.Parameters.AddWithValue("@Imagen", imagen);
                        cmdPeticion.ExecuteNonQuery();
                    }

                    // Obtener el ID de la última petición insertada
                    int idPeticion = (int)conexion.LastInsertRowId;

                    // Insertar la relación entre la petición y la clase
                    string queryClasePeticion = "INSERT INTO ClasesPeticiones (IdPeticion, IdClase) VALUES (@IdPeticion, @IdClase)";
                    using (var cmdClasePeticion = new SQLiteCommand(queryClasePeticion, conexion))
                    {
                        cmdClasePeticion.Parameters.AddWithValue("@IdPeticion", idPeticion);
                        cmdClasePeticion.Parameters.AddWithValue("@IdClase", idClase);
                        cmdClasePeticion.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la petición: {ex.Message}");
                    return false;
                }
            }
        }



        public static Peticion ObtenerPeticion(int idPeticion)
        {
            using (var conexion = new SQLiteConnection(DatabasePath))
            {
                conexion.Open();

                // Consulta principal para obtener los datos de la petición
                string queryPeticion = @"
            SELECT p.IdPeticion, p.Fecha, p.CifEstudiante, p.Imagen
            FROM Peticiones p
            WHERE p.IdPeticion = @IdPeticion";

                // Consulta para obtener las clases asociadas a la petición
                string queryClases = @"
            SELECT c.Nombre, c.NombreProfesor, c.CorreoProfesor
            FROM Clases c
            JOIN ClasesPeticiones cp ON cp.IdClase = c.IdClase
            WHERE cp.IdPeticion = @IdPeticion";

                using (var cmdPeticion = new SQLiteCommand(queryPeticion, conexion))
                {
                    cmdPeticion.Parameters.AddWithValue("@IdPeticion", idPeticion);

                    using (var readerPeticion = cmdPeticion.ExecuteReader())
                    {
                        if (readerPeticion.Read())
                        {
                            var peticion = new Peticion
                            {
                                Id = readerPeticion.GetInt32(0),
                                Fecha = readerPeticion.GetDateTime(1),
                                Estudiante = ObtenerEstudiantePorCif(readerPeticion.GetInt32(2).ToString()),
                                Imagen = readerPeticion["Imagen"] as byte[],
                                ClasesSeleccionadas = new List<Clase>() // Inicializamos la lista de clases
                            };

                            // Obtener las clases asociadas
                            using (var cmdClases = new SQLiteCommand(queryClases, conexion))
                            {
                                cmdClases.Parameters.AddWithValue("@IdPeticion", idPeticion);
                                using (var readerClases = cmdClases.ExecuteReader())
                                {
                                    while (readerClases.Read())
                                    {
                                        peticion.ClasesSeleccionadas.Add(new Clase
                                        {
                                            Nombre = readerClases.GetString(0),
                                            NombreProfesor = readerClases.GetString(1),
                                            CorreoProfesor = readerClases.GetString(2)
                                        });
                                    }
                                }
                            }

                            return peticion;
                        }
                        else
                        {
                            return default; // Si no se encuentra la petición, devolver null o el valor predeterminado
                        }
                    }
                }
            }
        }


    }
}
