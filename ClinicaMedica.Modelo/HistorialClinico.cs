using System;

namespace ClinicaMedica.Modelo
{
    public class HistorialClinico
    {
        public int IdHistorial { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaRegistro { get; set; }

        public required string Diagnostico { get; set; } = string.Empty;
        public required string NombrePaciente { get; set; } = string.Empty;
        public required string ApellidoPaciente { get; set; } = string.Empty;
        public required string NombreMedico { get; set; } = string.Empty;
    }
}
