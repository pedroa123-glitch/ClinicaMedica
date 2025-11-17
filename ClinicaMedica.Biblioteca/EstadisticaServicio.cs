using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ClinicaMedica.Negocio;

namespace ClinicaMedica.Negocio
{
    public class EstadisticaServicio
    {
        private ConexionBD cx = new ConexionBD();

        public int ContarPacientes()
        {
            using (var cn = cx.CrearConexion())
            {
                cn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Paciente", cn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int ContarMedicos()
        {
            using (var cn = cx.CrearConexion())
            {
                cn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Medico", cn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int ContarCitas()
        {
            using (var cn = cx.CrearConexion())
            {
                cn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Cita", cn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int ContarRecetas()
        {
            using (var cn = cx.CrearConexion())
            {
                cn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Receta", cn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
