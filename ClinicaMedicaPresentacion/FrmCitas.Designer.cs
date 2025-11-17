namespace ClinicaMedica.Presentacion
{
    partial class FrmCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboPaciente = new ComboBox();
            cboConsultorio = new ComboBox();
            cboMedico = new ComboBox();
            cboEstado = new ComboBox();
            dtFecha = new DateTimePicker();
            dgCitas = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Medico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Consultorio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 76);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Estado Cita:";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(143, 9);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(203, 28);
            cboPaciente.TabIndex = 8;
            // 
            // cboConsultorio
            // 
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(143, 145);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(203, 28);
            cboConsultorio.TabIndex = 9;
            // 
            // cboMedico
            // 
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(143, 76);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(203, 28);
            cboMedico.TabIndex = 10;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(488, 73);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(203, 28);
            cboEstado.TabIndex = 11;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(488, 10);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(203, 27);
            dtFecha.TabIndex = 12;
            // 
            // dgCitas
            // 
            dgCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCitas.Location = new Point(12, 304);
            dgCitas.Name = "dgCitas";
            dgCitas.RowHeadersWidth = 51;
            dgCitas.Size = new Size(776, 134);
            dgCitas.TabIndex = 13;
            dgCitas.CellContentClick += dgCitas_CellContentClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(30, 216);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(138, 63);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(208, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 63);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(370, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(138, 63);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(529, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 63);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgCitas);
            Controls.Add(dtFecha);
            Controls.Add(cboEstado);
            Controls.Add(cboMedico);
            Controls.Add(cboConsultorio);
            Controls.Add(cboPaciente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCitas";
            Load += FrmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboPaciente;
        private ComboBox cboConsultorio;
        private ComboBox cboMedico;
        private ComboBox cboEstado;
        private DateTimePicker dtFecha;
        private DataGridView dgCitas;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}