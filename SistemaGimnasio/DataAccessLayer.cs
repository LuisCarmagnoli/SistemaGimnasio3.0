using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                                VALUES (@NombreClase, @NombreInstructor, @Dias, @Horario, @Capacidad, @EspaciosDisponibles)";

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
                command.Parameters.Add(espaciosDisponibles);

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

        public void UpdateClase(Clase clase)
        {
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
                            Espacios_Disponibles = @EspaciosDisponibles 
                        WHERE ID_Clase = @IdClase";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdClase", clase.IdClase);
                command.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                command.Parameters.AddWithValue("@NombreInstructor", clase.NombreInstructor);
                command.Parameters.AddWithValue("@Dias", clase.Dias);
                command.Parameters.AddWithValue("@Horario", clase.Horario);
                command.Parameters.AddWithValue("@Capacidad", clase.Capacidad);
                command.Parameters.AddWithValue("@EspaciosDisponibles", clase.EspaciosDisponibles);

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
    }
}
