using System;

namespace ClinicaMedica.Modelo
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public int IdConsultorio { get; set; }

        public DateTime FechaHora { get; set; }
        public required string Estado { get; set; } = string.Empty;

        public required string NombrePaciente { get; set; } = string.Empty;
        public required string NombreMedico { get; set; } = string.Empty;
        public required string Consultorio { get; set; } = string.Empty;

        public string? Observaciones { get; set; }
    }
}
