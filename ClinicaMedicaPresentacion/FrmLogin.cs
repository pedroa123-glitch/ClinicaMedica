using ClinicaMedica.Negocio;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // ✅ Cambiado

namespace ClinicaMedica.Presentacion
{
    public partial class FrmLogin : Form
    {
        ConexionBD conexion = new ConexionBD();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void FrmLogin_Load(object sender, EventArgs e) { }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            using (var cn = conexion.CrearConexion())
            {
                cn.Open();

                string sql = @"SELECT COUNT(*) FROM Usuario 
                               WHERE Email = @Email AND [Contraseña] = @Pass";

                using (var cmd = new SqlCommand(sql, cn)) // ✅ Usa Microsoft.Data.SqlClient.SqlCommand
                {
                    cmd.Parameters.AddWithValue("@Email", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtContraseña.Text);

                    int existe = Convert.ToInt32(cmd.ExecuteScalar());

                    if (existe == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
        }
    }
}
