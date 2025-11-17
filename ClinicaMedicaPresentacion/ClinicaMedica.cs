using ClinicaMedica.Modelo;
using ClinicaMedica.Negocio;
using ClinicaMedicaPresentacion;
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
    public partial class FormClinicaMedica : Form
    {
        private readonly MedicoServicio servicio = new MedicoServicio();

        private int idMedicoSeleccionado = 0;
        private int idUsuarioSeleccionado = 0;
        public FormClinicaMedica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClinicaMedica_Load(object sender, EventArgs e)
        {
            CargarGrid();
            Limpiar();
        }
        private void CargarGrid()
        {
            var lista = servicio.Listar();
            dataGridView1.DataSource = lista;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Encabezados de columnas
            dataGridView1.Columns["IdMedico"].HeaderText = "Id Médico";
            dataGridView1.Columns["IdUsuario"].HeaderText = "Id Usuario";
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Especialidad"].HeaderText = "Especialidad";

            // ✅ ESTA ES LA COLUMNA NUEVA QUE QUIERES MOSTRAR
            dataGridView1.Columns["Contraseña"].HeaderText = "Contraseña";

            // ✅ Enmascarar la contraseña con '•'
            dataGridView1.CellFormatting += (s, ev) =>
            {
                if (dataGridView1.Columns[ev.ColumnIndex].Name == "Contraseña" && ev.Value is string txt)
                {
                    ev.Value = new string('•', txt.Length);
                    ev.FormattingApplied = true;
                }
            };
        }
        private void Limpiar()
        {
            txtNombreM.Text = "";
            txtApellidoM.Text = "";
            txtContraseñaM.Text = "";
            txtEmailM.Text = "";
            txtEspecialidadM.Text = "";

            idMedicoSeleccionado = 0;
            idUsuarioSeleccionado = 0;
        }

        private void lblNuevoM_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lblGuardarM_Click(object sender, EventArgs e)
        {
            try
            {
                servicio.Crear(
                    txtNombreM.Text,
                    txtApellidoM.Text,
                    txtEmailM.Text,
                    txtContraseñaM.Text,
                    txtEspecialidadM.Text
                );

                MessageBox.Show("Médico registrado correctamente");
                CargarGrid();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridView1.Rows[e.RowIndex];

                idMedicoSeleccionado = Convert.ToInt32(fila.Cells["IdMedico"].Value);
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

                txtNombreM.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellidoM.Text = fila.Cells["Apellido"].Value.ToString();
                txtEmailM.Text = fila.Cells["Email"].Value.ToString();
                txtEspecialidadM.Text = fila.Cells["Especialidad"].Value.ToString();
            }
        }

        private void lblEditarM_Click(object sender, EventArgs e)
        {
            if (idMedicoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un médico");
                return;
            }

            servicio.Editar(
                idMedicoSeleccionado,
                idUsuarioSeleccionado,
                txtNombreM.Text,
                txtApellidoM.Text,
                txtEmailM.Text,
                txtContraseñaM.Text,
                txtEspecialidadM.Text
            );

            MessageBox.Show("Registro actualizado");
            CargarGrid();
            Limpiar();
        }

        private void lblEliminarM_Click(object sender, EventArgs e)
        {
            if (idMedicoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un médico");
                return;
            }

            servicio.Eliminar(idMedicoSeleccionado, idUsuarioSeleccionado);

            MessageBox.Show("El médico fue eliminado");
            CargarGrid();
            Limpiar();
        }

        private void txtContraseñaM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes frmPacientes = new FrmPacientes();  // ← ESTE ES EL FORMULARIO DE PACIENTES
            frmPacientes.ShowDialog();         // ← Abrir como ventana modal
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialClinico h = new FrmHistorialClinico();
            h.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas ventana = new FrmCitas();
            ventana.ShowDialog();   // ✅ Abre la ventana correctamente y bloquea la anterior
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            FrmMedicamentos f = new FrmMedicamentos();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmReportes r = new FrmReportes();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEstadisticas e1 = new FrmEstadisticas();
            e1.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (var f = new FrmUsuarios())
            {
                f.ShowDialog();
            }
        }
    }
}
