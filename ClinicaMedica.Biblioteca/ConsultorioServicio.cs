using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ClinicaMedica.Modelo;

namespace ClinicaMedica.Negocio
{
    public class ConsultorioServicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<ConsultorioListado> Listar()
        {
            var lista = new List<ConsultorioListado>();

            string sql = @"
                SELECT c.IdConsultorio, c.Nombre, c.Especialidad, c.Ubicacion
                FROM Consultorio c
                ORDER BY c.Nombre;";

            using (var cn = _conexion.CrearConexion())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ConsultorioListado
                        {
                            IdConsultorio = dr.GetInt32(0),
                            Nombre = dr.IsDBNull(1) ? "" : dr.GetString(1),
                            Especialidad = dr.IsDBNull(2) ? "" : dr.GetString(2),
                            Ubicacion = dr.IsDBNull(3) ? "" : dr.GetString(3),
                        });
                    }
                }
            }
            return lista;
        }
    }
}
