using ClinicaMedica.Biblioteca;
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
    public partial class FrmCitas : Form
    {
        // 1) Instancias de servicios (NO estáticos)
        private readonly PacienteServicio _pacienteSvc = new PacienteServicio();
        private readonly MedicoServicio _medicoSvc = new MedicoServicio();
        private readonly ConsultorioServicio _consulSvc = new ConsultorioServicio();
        private readonly CitaServicio _citaSvc = new CitaServicio(); // si lo usas
        private int _idCitaSel = 0;

        public FrmCitas()
        {
            InitializeComponent();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            // PACIENTES
            var pacientes = _pacienteSvc.Listar()
                .Select(p => new
                {
                    p.IdPaciente,
                    NombreCompleto = (p.Nombre ?? "") + " " + (p.Apellido ?? "")
                })
                .ToList();

            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "NombreCompleto";
            cboPaciente.ValueMember = "IdPaciente";

            // MÉDICOS
            var medicos = _medicoSvc.Listar()
                .Select(m => new
                {
                    m.IdMedico,
                    NombreCompleto = (m.Nombre ?? "") + " " + (m.Apellido ?? "")
                })
                .ToList();

            cboMedico.DataSource = medicos;
            cboMedico.DisplayMember = "NombreCompleto";
            cboMedico.ValueMember = "IdMedico";

            // CONSULTORIOS
            var consultorios = _consulSvc.Listar();     // asumiendo propiedades IdConsultorio, Nombre
            cboConsultorio.DataSource = consultorios;
            cboConsultorio.DisplayMember = "Nombre";
            cboConsultorio.ValueMember = "IdConsultorio";

            // ESTADO DE CITA
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new[] { "Programada", "Atendida", "Cancelada" });

            // Deja los combos “sin selección” inicialmente
            cboPaciente.SelectedIndex = -1;
            cboMedico.SelectedIndex = -1;
            cboConsultorio.SelectedIndex = -1;
            cboEstado.SelectedIndex = 0;
            CargarCombos();
            CargarGrid();
            Limpiar();
        }
        private void CargarCombos()
        {
            // PACIENTES
            var pacientes = _pacienteSvc.Listar()
                .Select(p => new
                {
                    p.IdPaciente,
                    NombreCompleto = (p.Nombre ?? "") + " " + (p.Apellido ?? "")
                })
                .ToList();

            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "NombreCompleto";
            cboPaciente.ValueMember = "IdPaciente";

            // MEDICOS
            var medicos = _medicoSvc.Listar()
                .Select(m => new
                {
                    m.IdMedico,
                    NombreCompleto = (m.Nombre ?? "") + " " + (m.Apellido ?? "")
                })
                .ToList();

            cboMedico.DataSource = medicos;
            cboMedico.DisplayMember = "NombreCompleto";
            cboMedico.ValueMember = "IdMedico";

            // CONSULTORIOS
            var consultorios = _consulSvc.Listar();
            cboConsultorio.DataSource = consultorios;
            cboConsultorio.DisplayMember = "Nombre";
            cboConsultorio.ValueMember = "IdConsultorio";

            // ESTADOS
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new[] { "Programada", "Atendida", "Cancelada" });
            cboEstado.SelectedIndex = 0;
        }

        private void CargarGrid()
        {
            dgCitas.DataSource = _citaSvc.Listar();
            dgCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Limpiar()
        {
            _idCitaSel = 0;
            cboPaciente.SelectedIndex = -1;
            cboMedico.SelectedIndex = -1;
            cboConsultorio.SelectedIndex = -1;
            cboEstado.SelectedIndex = 0;
            dtFecha.Value = DateTime.Now;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedValue == null ||
            cboMedico.SelectedValue == null ||
            cboConsultorio.SelectedValue == null)
            {
                MessageBox.Show("Seleccione paciente, médico y consultorio.");
                return;
            }

            _citaSvc.Crear(
                idPaciente: (int)cboPaciente.SelectedValue,
                idMedico: (int)cboMedico.SelectedValue,
                idConsultorio: (int)cboConsultorio.SelectedValue,
                fecha: dtFecha.Value,
                estado: cboEstado.Text
            );

            MessageBox.Show("Cita registrada.");
            CargarGrid();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idCitaSel == 0)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            _citaSvc.Editar(
                idCita: _idCitaSel,
                idPaciente: (int)cboPaciente.SelectedValue,
                idMedico: (int)cboMedico.SelectedValue,
                idConsultorio: (int)cboConsultorio.SelectedValue,
                fecha: dtFecha.Value,
                estado: cboEstado.Text
            );

            MessageBox.Show("Cita actualizada.");
            CargarGrid();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idCitaSel == 0)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            _citaSvc.Eliminar(_idCitaSel);
            MessageBox.Show("Cita eliminada.");

            CargarGrid();
            Limpiar();
        }

        private void dgCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgCitas.Rows[e.RowIndex];

            _idCitaSel = Convert.ToInt32(row.Cells["IdCita"].Value);

            cboPaciente.SelectedValue = Convert.ToInt32(row.Cells["IdPaciente"].Value);
            cboMedico.SelectedValue = Convert.ToInt32(row.Cells["IdMedico"].Value);
            cboConsultorio.SelectedValue = Convert.ToInt32(row.Cells["IdConsultorio"].Value);

            dtFecha.Value = Convert.ToDateTime(row.Cells["FechaHora"].Value);
            cboEstado.Text = row.Cells["Estado"].Value.ToString();
        }
    }
}
