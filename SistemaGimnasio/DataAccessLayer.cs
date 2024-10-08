using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio
{
    public class DataAccessLayer
    {
        private SQLiteConnection connection = new SQLiteConnection("Data Source=|DataDirectory|SistemaGimnasioSQLite.db;Version=3;");

        public bool InsertClase(Clase clase)
        {
            // Validar que el nombre de la clase esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreClase) || clase.NombreClase.Length < 3 || clase.NombreClase.Length > 50)
            {
                MessageBox.Show("El nombre de la clase debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el nombre del instructor esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreInstructor) || clase.NombreInstructor.Length < 3 || clase.NombreInstructor.Length > 50)
            {
                MessageBox.Show("El nombre del instructor debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que los días estén entre 5 y 100 caracteres
            if (string.IsNullOrWhiteSpace(clase.Dias) || clase.Dias.Length < 5 || clase.Dias.Length > 100)
            {
                MessageBox.Show("Los días deben tener entre 5 y 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidarHorario(clase.Horario))
            {
                MessageBox.Show("Por favor, ingresa un horario válido en formato HH:MM:SS.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Salir del método si el formato es incorrecto
            }

            // Validar que la capacidad sea un número entre 1 y 100
            if (clase.Capacidad < 1 || clase.Capacidad > 100)
            {
                MessageBox.Show("La capacidad debe ser un número entre 1 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                connection.Open();
                string query = @"
                                INSERT INTO Clases(Nombre_Clase, Instructor, Dias, Horario, Capacidad, Espacios_Disponibles)
                                VALUES (@NombreClase, @NombreInstructor, @Dias, @Horario, @Capacidad, @Capacidad);
                                SELECT last_insert_rowid();";

                SQLiteParameter nombreClase = new SQLiteParameter("@NombreClase", clase.NombreClase);
                SQLiteParameter nombreInstructor = new SQLiteParameter("@NombreInstructor", clase.NombreInstructor);
                SQLiteParameter dias = new SQLiteParameter("@Dias", clase.Dias);
                SQLiteParameter horario = new SQLiteParameter("@Horario", clase.Horario);
                SQLiteParameter capacidad = new SQLiteParameter("@Capacidad", clase.Capacidad);
                SQLiteParameter espaciosDisponibles = new SQLiteParameter("@EspaciosDisponibles", clase.EspaciosDisponibles);

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(nombreClase);
                command.Parameters.Add(nombreInstructor);
                command.Parameters.Add(dias);
                command.Parameters.Add(horario);
                command.Parameters.Add(capacidad);

                // Ejecutar el comando e obtener el ID de la nueva clase
                int idClase = Convert.ToInt32(command.ExecuteScalar());

                // 2. Obtener todos los usuarios
                string selectUsuariosQuery = "SELECT ID_Usuario FROM Usuarios;";
                SQLiteCommand commandUsuarios = new SQLiteCommand(selectUsuariosQuery, connection);

                SQLiteDataReader reader = commandUsuarios.ExecuteReader();
                List<int> usuarios = new List<int>();

                while (reader.Read())
                {
                    usuarios.Add(reader.GetInt32(0)); // Agregar el ID de usuario a la lista
                }
                reader.Close();

                // 3. Insertar reservas para todos los usuarios
                string insertReservaQuery = @"
                                            INSERT INTO Reservas (ID_Usuario, ID_Clase, Estado)
                                            VALUES (@ID_Usuario, @ID_Clase, 'No reservado');";

                foreach (var idUsuario in usuarios)
                {
                    SQLiteCommand commandReserva = new SQLiteCommand(insertReservaQuery, connection);
                    commandReserva.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    commandReserva.Parameters.AddWithValue("@ID_Clase", idClase);
                    commandReserva.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
                
            }
        }

        public bool UpdateClase(Clase clase)
        {
            // Validar que el nombre de la clase esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreClase) || clase.NombreClase.Length < 3 || clase.NombreClase.Length > 50)
            {
                MessageBox.Show("El nombre de la clase debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el nombre del instructor esté entre 3 y 50 caracteres
            if (string.IsNullOrWhiteSpace(clase.NombreInstructor) || clase.NombreInstructor.Length < 3 || clase.NombreInstructor.Length > 50)
            {
                MessageBox.Show("El nombre del instructor debe tener entre 3 y 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que los días estén entre 5 y 100 caracteres
            if (string.IsNullOrWhiteSpace(clase.Dias) || clase.Dias.Length < 5 || clase.Dias.Length > 100)
            {
                MessageBox.Show("Los días deben tener entre 5 y 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidarHorario(clase.Horario))
            {
                MessageBox.Show("Por favor, ingresa un horario válido en formato HH:MM:SS.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Salir del método si el formato es incorrecto
            }

            // Validar que la capacidad sea un número entre 1 y 100
            if (clase.Capacidad < 1 || clase.Capacidad > 100)
            {
                MessageBox.Show("La capacidad debe ser un número entre 1 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                connection.Open();
                string query = @"
                                UPDATE Clases 
                                SET Nombre_Clase = @NombreClase, 
                                    Instructor = @NombreInstructor,
                                    Dias = @Dias,
                                    Horario = @Horario, 
                                    Capacidad = @Capacidad, 
                                    Espacios_Disponibles = Espacios_Disponibles + (@Capacidad - (SELECT Capacidad FROM Clases WHERE ID_Clase = @IdClase))
                                WHERE ID_Clase = @IdClase;";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@IdClase", clase.IdClase);
                command.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                command.Parameters.AddWithValue("@NombreInstructor", clase.NombreInstructor);
                command.Parameters.AddWithValue("@Dias", clase.Dias);
                command.Parameters.AddWithValue("@Horario", clase.Horario);
                command.Parameters.AddWithValue("@Capacidad", clase.Capacidad);
                //command.Parameters.AddWithValue("@EspaciosDisponibles", clase.EspaciosDisponibles);

                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteClase(int idClase)
        {
            try
            {
                connection.Open();

                // Borrar reservas con referencia a la clase
                string deleteReservasQuery = "DELETE FROM Reservas WHERE ID_Clase = @IdClase";
                SQLiteCommand commandReservas = new SQLiteCommand(deleteReservasQuery, connection);
                commandReservas.Parameters.AddWithValue("@IdClase", idClase);
                commandReservas.ExecuteNonQuery();

                // Borrar clase
                string query = "DELETE FROM Clases WHERE ID_Clase = @IdClase";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@IdClase", idClase);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void ReservarLugar(Reserva reserva, int idUsuario)
        {
            if (reserva.EspaciosDisponibles > 0)
            {
                if (reserva.Estado != "Reservado")
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                                UPDATE Reservas
                                SET Estado = 'Reservado'
                                WHERE ID_Usuario = @idUsuario AND ID_Reserva = @idReserva";

                        SQLiteCommand command = new SQLiteCommand(query, connection);

                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        command.Parameters.AddWithValue("@idReserva", reserva.IdReserva);
                        command.Parameters.AddWithValue("@Estado", reserva.Estado);
                        command.ExecuteNonQuery();

                        string updateClaseQuery = @"
                                UPDATE Clases
                                SET Espacios_Disponibles = Espacios_Disponibles - 1
                                WHERE ID_Clase = @idClase";

                        SQLiteCommand commandClase = new SQLiteCommand(updateClaseQuery, connection);
                        commandClase.Parameters.AddWithValue("@idClase", reserva.IdClase);
                        commandClase.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede reservar el lugar porque ya está reservado.");
                }
            }
            else
            {
                MessageBox.Show("No se puede reservar porque no hay espacios disponibles.");
            }
        }

        public void CancelarReserva(Reserva reserva, int idUsuario)
        {
            if (reserva.Estado != "No reservado")
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE Reservas
                        SET Estado = 'No reservado'
                        WHERE ID_Usuario = @idUsuario AND ID_Reserva = @idReserva";

                    SQLiteCommand command = new SQLiteCommand(query, connection);

                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@idReserva", reserva.IdReserva);
                    command.Parameters.AddWithValue("@Estado", reserva.Estado);

                    command.ExecuteNonQuery();

                    string updateClaseQuery = @"
                                UPDATE Clases
                                SET Espacios_Disponibles = Espacios_Disponibles + 1
                                WHERE ID_Clase = @idClase";

                    SQLiteCommand commandClase = new SQLiteCommand(updateClaseQuery, connection);
                    commandClase.Parameters.AddWithValue("@idClase", reserva.IdClase); //
                    commandClase.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("No se puede cancelar la reserva ya que no has reservado un lugar aún.");
            }
        }

        private bool ValidarHorario(string horario)
        {
            // Expresión regular para validar el formato HH:MM:SS
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            return Regex.IsMatch(horario, pattern);
        }

        public List<Clase> SearchClases(string searchTerm)
        {
            List<Clase> clases = new List<Clase>();
            try
            {
                connection.Open();
                string query = @"
                                SELECT ID_Clase, Nombre_Clase, Instructor, Dias, Horario, Capacidad, Espacios_Disponibles
                                FROM Clases
                                WHERE Nombre_Clase LIKE @SearchTerm 
                                   OR Dias LIKE @SearchTerm
                                   OR Instructor LIKE @SearchTerm 
                                   OR Horario LIKE @SearchTerm";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clases.Add(new Clase
                    {
                        IdClase = int.Parse(reader["ID_Clase"].ToString()),
                        NombreClase = reader["Nombre_Clase"].ToString(),
                        NombreInstructor = reader["Instructor"].ToString(),
                        Dias = reader["Dias"].ToString(),
                        Horario = reader["Horario"].ToString(),
                        Capacidad = int.Parse(reader["Capacidad"].ToString()),
                        EspaciosDisponibles = int.Parse(reader["Espacios_Disponibles"].ToString())
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return clases;
        }

        public List<Reserva> SearchReservas(string searchTerm, int idUsuario)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                connection.Open();
                string query = @"
                                SELECT 
                                    Clases.ID_Clase,
                                    Clases.Nombre_Clase,
                                    Clases.Instructor,
                                    Clases.Dias,
                                    Clases.Horario,
                                    Clases.Capacidad,
                                    Clases.Espacios_Disponibles,
                                    Reservas.ID_Reserva,
                                    Reservas.Estado
                                FROM 
                                    Clases
                                INNER JOIN 
                                    Reservas ON Clases.ID_Clase = Reservas.ID_Clase
                                WHERE 
                                    Reservas.ID_Usuario = @IdUsuario
                                    AND (
                                        Clases.Nombre_Clase LIKE @SearchTerm 
                                        OR Clases.Dias LIKE @SearchTerm
                                        OR Clases.Instructor LIKE @SearchTerm 
                                        OR Clases.Horario LIKE @SearchTerm
                                        OR Reservas.Estado LIKE @SearchTerm
                                    );";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reservas.Add(new Reserva
                    {
                        IdClase = int.Parse(reader["ID_Clase"].ToString()),
                        NombreClase = reader["Nombre_Clase"].ToString(),
                        NombreInstructor = reader["Instructor"].ToString(),
                        Dias = reader["Dias"].ToString(),
                        Horario = reader["Horario"].ToString(),
                        Capacidad = int.Parse(reader["Capacidad"].ToString()),
                        EspaciosDisponibles = int.Parse(reader["Espacios_Disponibles"].ToString()),
                        IdReserva = int.Parse(reader["ID_Reserva"].ToString()),
                        Estado = reader["Estado"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return reservas;
        }

        public List<Clase> GetClases()
        {
            List<Clase> clases = new List<Clase>();
            try
            {
                connection.Open();
                string query = @"SELECT ID_Clase, Nombre_Clase, Instructor, Dias, Horario, Capacidad, Espacios_Disponibles
                                FROM Clases";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clases.Add(new Clase
                    {
                        IdClase = int.Parse(reader["ID_Clase"].ToString()),
                        NombreClase = reader["Nombre_Clase"].ToString(),
                        NombreInstructor = reader["Instructor"].ToString(),
                        Dias = reader["Dias"].ToString(),
                        Horario = reader["Horario"].ToString(),
                        Capacidad = int.Parse(reader["Capacidad"].ToString()),
                        EspaciosDisponibles = int.Parse(reader["Espacios_Disponibles"].ToString())
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return clases;
        }

        public List<Reserva> GetReservas(int idUsuario)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                connection.Open();
                string query = @"
                                SELECT 
                                Clases.ID_Clase,
                                Clases.Nombre_Clase,
                                Clases.Instructor,
                                Clases.Dias,
                                Clases.Horario,
                                Clases.Capacidad,
                                Clases.Espacios_Disponibles,
                                Reservas.ID_Reserva,
                                Reservas.Estado
                            FROM 
                                Clases
                            INNER JOIN 
                                Reservas ON Clases.ID_Clase = Reservas.ID_Clase
                            WHERE 
                                Reservas.ID_Usuario = @IdUsuario;";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reservas.Add(new Reserva
                    {
                        IdClase = int.Parse(reader["ID_Clase"].ToString()),
                        NombreClase = reader["Nombre_Clase"].ToString(),
                        NombreInstructor = reader["Instructor"].ToString(),
                        Dias = reader["Dias"].ToString(),
                        Horario = reader["Horario"].ToString(),
                        Capacidad = int.Parse(reader["Capacidad"].ToString()),
                        EspaciosDisponibles = int.Parse(reader["Espacios_Disponibles"].ToString()),
                        IdReserva = int.Parse(reader["ID_Reserva"].ToString()),
                        Estado = reader["Estado"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return reservas;
        }

    }
}
