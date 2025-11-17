using System;

namespace ClinicaMedica.Modelo
{
    public class Paciente1
    {
        public int IdPaciente { get; set; }

        public required string DNI { get; set; } = string.Empty;
        public required string Nombre { get; set; } = string.Empty;
        public required string Apellido { get; set; } = string.Empty;

        public DateTime? FechaNacimiento { get; set; }

        public required string Telefono { get; set; } = string.Empty;
        public required string Direccion { get; set; } = string.Empty;
        public required string Genero { get; set; } = string.Empty;
    }
}
