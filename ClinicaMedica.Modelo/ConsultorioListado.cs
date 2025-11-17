using System;

namespace ClinicaMedica.Modelo
{
    public class ConsultorioListado
    {
        public int IdConsultorio { get; set; }

        public required string Nombre { get; set; } = string.Empty;
        public required string Especialidad { get; set; } = string.Empty;
        public required string Ubicacion { get; set; } = string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
