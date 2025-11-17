using ClinicaMedica.Modelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ClinicaMedica.Negocio
{
    public class CitaServicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();
        public List<Cita> Listar()
        {
            var lista = new List<Cita>();

            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"
                SELECT c.IdCita, c.IdPaciente, c.IdMedico, c.IdConsultorio,
                       c.FechaHora, c.Estado,
                       p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                       u.Nombre + ' ' + u.Apellido AS NombreMedico,
                       cons.Nombre AS Consultorio
                FROM Cita c
                INNER JOIN Paciente p ON p.IdPaciente = c.IdPaciente
                INNER JOIN Medico m ON m.IdMedico = c.IdMedico
                INNER JOIN Usuario u ON u.IdUsuario = m.IdUsuario
                INNER JOIN Consultorio cons ON cons.IdConsultorio = c.IdConsultorio
                ORDER BY c.FechaHora DESC";

                using (var cmd = new SqlCommand(sql, cn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Cita
                        {
                            IdCita = dr.GetInt32(0),
                            IdPaciente = dr.GetInt32(1),
                            IdMedico = dr.GetInt32(2),
                            IdConsultorio = dr.GetInt32(3),
                            FechaHora = dr.GetDateTime(4),
                            Estado = dr.GetString(5),
                            NombrePaciente = dr.GetString(6),
                            NombreMedico = dr.GetString(7),
                            Consultorio = dr.GetString(8)
                        });
                    }
                }
            }

            return lista;
        }
        public void Crear(int idPaciente, int idMedico, int idConsultorio, DateTime fecha, string estado)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"INSERT INTO Cita(IdPaciente, IdMedico, IdConsultorio, FechaHora, Estado)
                               VALUES (@p, @m, @c, @f, @e)";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@p", idPaciente);
                    cmd.Parameters.AddWithValue("@m", idMedico);
                    cmd.Parameters.AddWithValue("@c", idConsultorio);
                    cmd.Parameters.AddWithValue("@f", fecha);
                    cmd.Parameters.AddWithValue("@e", estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Editar(int idCita, int idPaciente, int idMedico, int idConsultorio, DateTime fecha, string estado)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"UPDATE Cita SET 
                               IdPaciente=@p, IdMedico=@m, IdConsultorio=@c,
                               FechaHora=@f, Estado=@e
                               WHERE IdCita=@id";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idCita);
                    cmd.Parameters.AddWithValue("@p", idPaciente);
                    cmd.Parameters.AddWithValue("@m", idMedico);
                    cmd.Parameters.AddWithValue("@c", idConsultorio);
                    cmd.Parameters.AddWithValue("@f", fecha);
                    cmd.Parameters.AddWithValue("@e", estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Eliminar(int idCita)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"DELETE FROM Cita WHERE IdCita = @id";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idCita);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
