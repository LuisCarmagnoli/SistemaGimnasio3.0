using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio
{
    public class DataAccessLayer
    {
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SistemaGimnasio;Data Source=DESKTOP-PP0K0MS");

        public void InsertClase(Clase clase)
        {
            try
            {
                connection.Open();
                string query = @"
                                INSERT INTO Clases(Nombre_Clase, Instructor, Dias, Horario, Capacidad, Espacios_Disponibles)
                                VALUES (@NombreClase, @NombreInstructor, @Dias, @Horario, @Capacidad, @Capacidad);
                                SELECT SCOPE_IDENTITY();";

                SqlParameter nombreClase = new SqlParameter("@NombreClase", clase.NombreClase);
                SqlParameter nombreInstructor = new SqlParameter("@NombreInstructor", clase.NombreInstructor);
                SqlParameter dias = new SqlParameter("@Dias", clase.Dias);
                SqlParameter horario = new SqlParameter("@Horario", clase.Horario);
                SqlParameter capacidad = new SqlParameter("@Capacidad", clase.Capacidad);
                SqlParameter espaciosDisponibles = new SqlParameter("@EspaciosDisponibles", clase.EspaciosDisponibles);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(nombreClase);
                command.Parameters.Add(nombreInstructor);
                command.Parameters.Add(dias);
                command.Parameters.Add(horario);
                command.Parameters.Add(capacidad);

                // Ejecutar el comando e obtener el ID de la nueva clase
                int idClase = Convert.ToInt32(command.ExecuteScalar());

                // 2. Obtener todos los usuarios
                string selectUsuariosQuery = "SELECT ID_Usuario FROM Usuarios;";
                SqlCommand commandUsuarios = new SqlCommand(selectUsuariosQuery, connection);

                SqlDataReader reader = commandUsuarios.ExecuteReader();
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
                    SqlCommand commandReserva = new SqlCommand(insertReservaQuery, connection);
                    commandReserva.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    commandReserva.Parameters.AddWithValue("@ID_Clase", idClase);
                    commandReserva.ExecuteNonQuery();
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
        }

        public void UpdateClase(Clase clase)
        {
            try
            {
                connection.Open();
                string query = @"
                                DECLARE @auxCapacidad INT;

                                SELECT @auxCapacidad = Capacidad 
                                FROM Clases 
                                WHERE ID_Clase = @IdClase;

                                UPDATE Clases 
                                SET Nombre_Clase = @NombreClase, 
                                    Instructor = @NombreInstructor,
                                    Dias = @Dias,
                                    Horario = @Horario, 
                                    Capacidad = @Capacidad, 
                                    Espacios_Disponibles = Espacios_Disponibles + (@Capacidad - @auxCapacidad)
                                WHERE ID_Clase = @IdClase;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdClase", clase.IdClase);
                command.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                command.Parameters.AddWithValue("@NombreInstructor", clase.NombreInstructor);
                command.Parameters.AddWithValue("@Dias", clase.Dias);
                command.Parameters.AddWithValue("@Horario", clase.Horario);
                command.Parameters.AddWithValue("@Capacidad", clase.Capacidad);
                //command.Parameters.AddWithValue("@EspaciosDisponibles", clase.EspaciosDisponibles);

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

        public void DeleteClase(int idClase)
        {
            try
            {
                connection.Open();

                // Borrar reservas con referencia a la clase
                string deleteReservasQuery = "DELETE FROM Reservas WHERE ID_Clase = @IdClase";
                SqlCommand commandReservas = new SqlCommand(deleteReservasQuery, connection);
                commandReservas.Parameters.AddWithValue("@IdClase", idClase);
                commandReservas.ExecuteNonQuery();

                // Borrar clase
                string query = "DELETE FROM Clases WHERE ID_Clase = @IdClase";

                SqlCommand command = new SqlCommand(query, connection);
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

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                SqlDataReader reader = command.ExecuteReader();

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

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader();

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

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

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

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader();

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

        public void ReservarLugar(Reserva reserva, int idUsuario)
        {
            try
            {
                connection.Open();
                string query = @"
                                UPDATE Reservas
                                SET Estado = 'Reservado'
                                WHERE ID_Usuario = @idUsuario AND ID_Reserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                command.Parameters.AddWithValue("@idReserva", reserva.IdReserva);
                command.Parameters.AddWithValue("@Estado", reserva.Estado);
                command.ExecuteNonQuery();

                string updateClaseQuery = @"
                                UPDATE Clases
                                SET Espacios_Disponibles = Espacios_Disponibles - 1
                                WHERE ID_Clase = @idClase";

                SqlCommand commandClase = new SqlCommand(updateClaseQuery, connection);
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

        public void CancelarReserva(Reserva reserva, int idUsuario)
        {
            try
            {
                connection.Open();
                string query = @"
                        UPDATE Reservas
                        SET Estado = 'No reservado'
                        WHERE ID_Usuario = @idUsuario AND ID_Reserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                command.Parameters.AddWithValue("@idReserva", reserva.IdReserva);
                command.Parameters.AddWithValue("@Estado", reserva.Estado);

                command.ExecuteNonQuery();

                string updateClaseQuery = @"
                                UPDATE Clases
                                SET Espacios_Disponibles = Espacios_Disponibles + 1
                                WHERE ID_Clase = @idClase";

                SqlCommand commandClase = new SqlCommand(updateClaseQuery, connection);
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
    }
}
