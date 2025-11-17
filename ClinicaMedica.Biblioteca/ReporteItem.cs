using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Negocio
{
    public class ReporteItem
    {
        public int IdReporte { get; set; }
        public DateTime Fecha { get; set; }
        public required string TipoReporte { get; set; } = string.Empty;
        public required string Medico { get; set; } = string.Empty;
    }

    public class ReporteServicio
    {
        private readonly ConexionBD _cx = new ConexionBD();

        public List<ReporteItem> Listar(DateTime desde, DateTime hasta)
        {
            var lista = new List<ReporteItem>();

            using var cn = _cx.CrearConexion();
            cn.Open();

            string sql = @"
                SELECT r.IdReporte, r.Fecha, r.TipoReporte,
                       (u.Nombre + ' ' + u.Apellido) AS Medico
                FROM Reporte r
                JOIN Medico m ON r.IdMedico = m.IdMedico
                JOIN Usuario u ON m.IdUsuario = u.IdUsuario
                WHERE r.Fecha BETWEEN @desde AND @hasta
                ORDER BY r.Fecha DESC;";

            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new ReporteItem
                {
                    IdReporte = rd.GetInt32(0),
                    Fecha = rd.GetDateTime(1),
                    TipoReporte = rd.IsDBNull(2) ? string.Empty : rd.GetString(2),
                    Medico = rd.IsDBNull(3) ? string.Empty : rd.GetString(3)
                });
            }

            return lista;
        }
    }
}
