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
    internal class ClaseRepository
    {
        public void InsertarClase(Clase clase)
        {
            string sql = "INSERT INTO Clases (Nombre, NombreProfesor, CorreoProfesor) VALUES (@nombre, @nombreProfesor, @correoProfesor)";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@nombreProfesor", clase.NombreProfesor);
                    cmd.Parameters.AddWithValue("@correoProfesor", clase.CorreoProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Clase> ObtenerClases()
        {
            string sql = "SELECT Nombre, NombreProfesor, CorreoProfesor FROM Clases";
            var clases = new List<Clase>();

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clases.Add(new Clase
                        {
                            Nombre = reader["Nombre"].ToString(),
                            NombreProfesor = reader["NombreProfesor"].ToString(),
                            CorreoProfesor = reader["CorreoProfesor"].ToString()
                        });
                    }
                }
            }

            return clases;
        }

        public void ActualizarClase(Clase clase)
        {
            string sql = "UPDATE Clases SET NombreProfesor = @nombreProfesor, CorreoProfesor = @correoProfesor WHERE Nombre = @nombre";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", clase.Nombre);
                    cmd.Parameters.AddWithValue("@nombreProfesor", clase.NombreProfesor);
                    cmd.Parameters.AddWithValue("@correoProfesor", clase.CorreoProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarClase(string nombre)
        {
            string sql = "DELETE FROM Clases WHERE Nombre = @nombre";

            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();
                using (var cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
