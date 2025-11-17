using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ClinicaMedica.Modelo;
using ClinicaMedica.Negocio;

namespace ClinicaMedica.Negocio
{
    public class Historial_Servicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<HistorialClinico> Listar()
        {
            var lista = new List<HistorialClinico>();

            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"
                SELECT h.IdHistorial, h.IdPaciente, h.IdMedico, h.FechaRegistro, h.Diagnostico,
                       p.Nombre  AS NombrePaciente, p.Apellido AS ApellidoPaciente,
                       m.IdMedico, u.Nombre AS NombreMedico
                FROM HistorialClinico h
                INNER JOIN Paciente p ON h.IdPaciente = p.IdPaciente
                LEFT JOIN Medico m    ON h.IdMedico   = m.IdMedico
                LEFT JOIN Usuario u   ON m.IdUsuario  = u.IdUsuario
                ORDER BY h.FechaRegistro DESC";

                using (var cmd = new SqlCommand(sql, cn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new HistorialClinico
                        {
                            IdHistorial = rd.GetInt32(0),
                            IdPaciente = rd.GetInt32(1),
                            IdMedico = rd.IsDBNull(2) ? 0 : rd.GetInt32(2),
                            FechaRegistro = rd.GetDateTime(3),
                            Diagnostico = rd.IsDBNull(4) ? "" : rd.GetString(4),
                            NombrePaciente = rd.GetString(5),
                            ApellidoPaciente = rd.GetString(6),
                            NombreMedico = rd.IsDBNull(8) ? "" : rd.GetString(8)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
