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
    public partial class FrmReportes : Form
    {
        private ReporteServicio servicio = new ReporteServicio();

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var lista = servicio.Listar(
                dtpDesde.Value.Date,
                dtpHasta.Value.Date
            );

            dgvReportes.DataSource = lista;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
