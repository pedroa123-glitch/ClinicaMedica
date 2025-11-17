using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ClinicaMedica.Negocio
{
    public class ConexionBD
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["ClinicaMedica"].ConnectionString;

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}