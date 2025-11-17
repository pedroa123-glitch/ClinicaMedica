using ClinicaMedica.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Presentacion
{
   
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioServicio _svc = new UsuarioServicio();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarGrid(string filtro = "")
        {
            dgUsuarios.DataSource = _svc.Listar(filtro);
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuarios.Columns["IdUsuario"].HeaderText = "ID";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrid(txtBuscar.Text.Trim());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
