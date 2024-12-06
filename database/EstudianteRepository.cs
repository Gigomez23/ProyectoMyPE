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
    internal class EstudianteRepository
    {
        public void InsertarEstudiante(Estudiante estudiante)
        {
            string sql = "INSERT INTO Estudiantes (Cif, Nombre, FechaNacimiento) VALUES (@cif, @nombre, @fechaNacimiento)";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@cif", estudiante.Cif);
                    cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            string sql = "SELECT Cif, Nombre, FechaNacimiento FROM Estudiantes";
            var estudiantes = new List<Estudiante>();

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantes.Add(new Estudiante
                        {
                            Cif = Convert.ToInt32(reader["Cif"]),
                            Nombre = reader["Nombre"].ToString(),
                            FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString())
                        });
                    }
                }
            }

            return estudiantes;
        }

        public Estudiante ObtenerEstudiantePorCif(int cif)
        {
            string sql = "SELECT Cif, Nombre, FechaNacimiento FROM Estudiantes WHERE Cif = @cif";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@cif", cif);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Estudiante
                            {
                                Cif = Convert.ToInt32(reader["Cif"]),
                                Nombre = reader["Nombre"].ToString(),
                                FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString())
                            };
                        }
                    }
                }
            }

            return null; // Si no se encuentra el estudiante
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            string sql = "UPDATE Estudiantes SET Nombre = @nombre, FechaNacimiento = @fechaNacimiento WHERE Cif = @cif";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@cif", estudiante.Cif);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEstudiante(int cif)
        {
            string sql = "DELETE FROM Estudiantes WHERE Cif = @cif";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@cif", cif);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
