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
    public partial class FrmEstadisticas : Form
    {
        private EstadisticaServicio svc = new EstadisticaServicio();
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            lblPacientes.Text = svc.ContarPacientes().ToString();
            lblMedicos.Text = svc.ContarMedicos().ToString();
            lblCitas.Text = svc.ContarCitas().ToString();
            lblRecetas.Text = svc.ContarRecetas().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEstadisticas_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmEstadisticas_Load_2(object sender, EventArgs e)
        {
            lblPacientes.Text = svc.ContarPacientes().ToString();
            lblMedicos.Text = svc.ContarMedicos().ToString();
            lblCitas.Text = svc.ContarCitas().ToString();
            lblRecetas.Text = svc.ContarRecetas().ToString();
            

        }
    }
}
