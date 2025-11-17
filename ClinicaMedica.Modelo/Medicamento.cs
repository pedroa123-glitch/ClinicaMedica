using System;

namespace ClinicaMedica.Modelo
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }

        public required string Nombre { get; set; } = string.Empty;
        public required string Descripcion { get; set; } = string.Empty;

        public int Stock { get; set; }
    }
}
