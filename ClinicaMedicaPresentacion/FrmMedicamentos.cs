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
    public partial class FrmMedicamentos : Form
    {
        private readonly MedicamentoServicio servicio = new MedicamentoServicio();
        private int idSel = 0;
        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            Limpiar();

        }
        private void CargarGrid()
        {
            dgMedicamentos.DataSource = servicio.Listar();
            dgMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Limpiar()
        {
            idSel = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            servicio.Crear(
               txtNombre.Text,
               txtDescripcion.Text,
               int.Parse(txtStock.Text)
           );

            MessageBox.Show("Medicamento registrado.");
            CargarGrid();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSel == 0)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            servicio.Editar(
                idSel,
                txtNombre.Text,
                txtDescripcion.Text,
                int.Parse(txtStock.Text)
            );

            MessageBox.Show("Medicamento actualizado.");
            CargarGrid();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSel == 0)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            servicio.Eliminar(idSel);

            MessageBox.Show("Medicamento eliminado.");
            CargarGrid();
            Limpiar();
        }

        private void dgMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgMedicamentos.Rows[e.RowIndex];

            idSel = Convert.ToInt32(fila.Cells["IdMedicamento"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtStock.Text = fila.Cells["Stock"].Value.ToString();
        }
    }
}
