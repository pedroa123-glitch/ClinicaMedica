using ClinicaMedica.Presentacion;

namespace ClinicaMedicaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // 1) LOGIN (modal). Si NO es OK, se cierra la app.
            using (var login = new FrmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            // 2) FORMULARIO DE TRABAJADORES (MÉDICOS), modal
            using (var frmMedicos = new FormClinicaMedica())
            {
                frmMedicos.ShowDialog();
            }

          
            


        }
    }
}