using ClinicaMedica.Biblioteca;
using ClinicaMedica.Modelo;
using ClinicaMedica.Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaMedicaPresentacion
{
    public partial class FrmPacientes : Form
    {
        PacienteServicio servicio = new PacienteServicio();
        int? seleccionadoId = null;
        public FrmPacientes()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGenero.Items.Add("");
            cboGenero.Items.Add("M");
            cboGenero.Items.Add("F");
            cboGenero.SelectedIndex = 0;
            var lista = servicio.Listar();
            dataGridView1.DataSource = lista;
            dtpFN.ShowCheckBox = true;
            dtpFN.Checked = false;
            CargarGrid();
        }
        private void CargarGrid()
        {
            dataGridView1.DataSource = servicio.Listar();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Limpiar()
        {
            seleccionadoId = null;
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cboGenero.SelectedIndex = 0;
            dtpFN.Checked = false;
        }
        private Paciente1 LeerFormulario()
        {
            return new Paciente1
            {
                IdPaciente = seleccionadoId ?? 0,
                DNI = txtDNI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? string.Empty : txtTelefono.Text.Trim(),
                Direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? string.Empty : txtDireccion.Text.Trim(),
                Genero = string.IsNullOrWhiteSpace(cboGenero.Text) ? string.Empty : cboGenero.Text,
                FechaNacimiento = dtpFN.Checked ? dtpFN.Value.Date : (DateTime?)null
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (seleccionadoId == null)
            {
                MessageBox.Show("Selecciona un paciente.");
                return;
            }

            var p = LeerFormulario();

            if (servicio.Editar(p))
            {
                MessageBox.Show("Paciente actualizado.");
                CargarGrid();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (seleccionadoId == null)
            {
                MessageBox.Show("Selecciona un paciente.");
                return;
            }

            if (MessageBox.Show("¿Eliminar paciente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (servicio.Eliminar(seleccionadoId.Value))
                {
                    MessageBox.Show("Paciente eliminado.");
                    CargarGrid();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var p = LeerFormulario();

            // Validación básica
            if (string.IsNullOrWhiteSpace(p.DNI) || p.DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                return;
            }

            int id = servicio.Crear(p);
            MessageBox.Show("Paciente creado. Id = " + id);
            CargarGrid();
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGridView1.Rows[e.RowIndex];

            seleccionadoId = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
            txtDNI.Text = fila.Cells["DNI"].Value?.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();

            var gen = fila.Cells["Genero"].Value?.ToString();
            cboGenero.Text = string.IsNullOrWhiteSpace(gen) ? "" : gen;

            if (fila.Cells["FechaNacimiento"].Value == DBNull.Value)
            {
                dtpFN.Checked = false;
            }
            else
            {
                dtpFN.Checked = true;
                dtpFN.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

