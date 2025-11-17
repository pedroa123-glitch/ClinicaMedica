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
    public partial class FrmHistorialClinico : Form
    {
        Historial_Servicio servicio = new Historial_Servicio();
        public FrmHistorialClinico()
        {
            InitializeComponent();
        }

        private void FrmHistorialClinico_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }
        private void CargarHistorial()
        {
            var lista = servicio.Listar();
            dgHistorial.DataSource = lista;
            dgHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdHistorial.Text = dgHistorial.Rows[e.RowIndex].Cells["IdHistorial"].Value.ToString();
                txtPaciente.Text = dgHistorial.Rows[e.RowIndex].Cells["NombrePaciente"].Value + " " +
                                   dgHistorial.Rows[e.RowIndex].Cells["ApellidoPaciente"].Value;

                txtMedico.Text = dgHistorial.Rows[e.RowIndex].Cells["NombreMedico"].Value.ToString();
                txtDiagnostico.Text = dgHistorial.Rows[e.RowIndex].Cells["Diagnostico"].Value.ToString();
                txtFecha.Text = Convert.ToDateTime(
                dgHistorial.Rows[e.RowIndex].Cells["FechaRegistro"].Value
                ).ToShortDateString();

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdHistorial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
