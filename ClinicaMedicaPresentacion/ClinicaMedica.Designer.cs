namespace ClinicaMedica.Presentacion
{
    partial class FormClinicaMedica
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
            txtNombreM = new TextBox();
            txtEspecialidadM = new TextBox();
            txtContraseñaM = new TextBox();
            txtEmailM = new TextBox();
            txtApellidoM = new TextBox();
            lblNuevoM = new Button();
            lblGuardarM = new Button();
            lblEditarM = new Button();
            lblEliminarM = new Button();
            dataGridView1 = new DataGridView();
            btnPacientes = new Button();
            btnHistorial = new Button();
            btnCitas = new Button();
            btnMedicamentos = new Button();
            button1 = new Button();
            button2 = new Button();
            btnUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Medico:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido Medico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 29);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 108);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Especialidad:";
            // 
            // txtNombreM
            // 
            txtNombreM.Location = new Point(140, 29);
            txtNombreM.Name = "txtNombreM";
            txtNombreM.Size = new Size(259, 27);
            txtNombreM.TabIndex = 5;
            // 
            // txtEspecialidadM
            // 
            txtEspecialidadM.Location = new Point(539, 104);
            txtEspecialidadM.Name = "txtEspecialidadM";
            txtEspecialidadM.Size = new Size(259, 27);
            txtEspecialidadM.TabIndex = 6;
            // 
            // txtContraseñaM
            // 
            txtContraseñaM.Location = new Point(539, 29);
            txtContraseñaM.Name = "txtContraseñaM";
            txtContraseñaM.Size = new Size(259, 27);
            txtContraseñaM.TabIndex = 7;
            txtContraseñaM.TextChanged += txtContraseñaM_TextChanged;
            // 
            // txtEmailM
            // 
            txtEmailM.Location = new Point(140, 178);
            txtEmailM.Name = "txtEmailM";
            txtEmailM.Size = new Size(259, 27);
            txtEmailM.TabIndex = 8;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(140, 101);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(259, 27);
            txtApellidoM.TabIndex = 9;
            // 
            // lblNuevoM
            // 
            lblNuevoM.Location = new Point(12, 234);
            lblNuevoM.Name = "lblNuevoM";
            lblNuevoM.Size = new Size(108, 71);
            lblNuevoM.TabIndex = 10;
            lblNuevoM.Text = "Nuevo";
            lblNuevoM.UseVisualStyleBackColor = true;
            lblNuevoM.Click += lblNuevoM_Click;
            // 
            // lblGuardarM
            // 
            lblGuardarM.Location = new Point(126, 234);
            lblGuardarM.Name = "lblGuardarM";
            lblGuardarM.Size = new Size(107, 71);
            lblGuardarM.TabIndex = 11;
            lblGuardarM.Text = "Guardar ";
            lblGuardarM.UseVisualStyleBackColor = true;
            lblGuardarM.Click += lblGuardarM_Click;
            // 
            // lblEditarM
            // 
            lblEditarM.Location = new Point(239, 234);
            lblEditarM.Name = "lblEditarM";
            lblEditarM.Size = new Size(102, 71);
            lblEditarM.TabIndex = 12;
            lblEditarM.Text = "Editar";
            lblEditarM.UseVisualStyleBackColor = true;
            lblEditarM.Click += lblEditarM_Click;
            // 
            // lblEliminarM
            // 
            lblEliminarM.Location = new Point(347, 234);
            lblEliminarM.Name = "lblEliminarM";
            lblEliminarM.Size = new Size(89, 71);
            lblEliminarM.TabIndex = 13;
            lblEliminarM.Text = "Eliminar";
            lblEliminarM.UseVisualStyleBackColor = true;
            lblEliminarM.Click += lblEliminarM_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1003, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(442, 234);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(106, 71);
            btnPacientes.TabIndex = 15;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(554, 234);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(121, 71);
            btnHistorial.TabIndex = 16;
            btnHistorial.Text = "Historial Clinico";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(681, 234);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(94, 71);
            btnCitas.TabIndex = 17;
            btnCitas.Text = "Agenda de Citas";
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.Location = new Point(781, 234);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(118, 71);
            btnMedicamentos.TabIndex = 18;
            btnMedicamentos.Text = "Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = true;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(905, 234);
            button1.Name = "button1";
            button1.Size = new Size(118, 71);
            button1.TabIndex = 19;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1043, 234);
            button2.Name = "button2";
            button2.Size = new Size(118, 71);
            button2.TabIndex = 20;
            button2.Text = "Estadisticas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(1043, 343);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(118, 71);
            btnUsuarios.TabIndex = 21;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // FormClinicaMedica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 567);
            Controls.Add(btnUsuarios);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMedicamentos);
            Controls.Add(btnCitas);
            Controls.Add(btnHistorial);
            Controls.Add(btnPacientes);
            Controls.Add(dataGridView1);
            Controls.Add(lblEliminarM);
            Controls.Add(lblEditarM);
            Controls.Add(lblGuardarM);
            Controls.Add(lblNuevoM);
            Controls.Add(txtApellidoM);
            Controls.Add(txtEmailM);
            Controls.Add(txtContraseñaM);
            Controls.Add(txtEspecialidadM);
            Controls.Add(txtNombreM);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormClinicaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicaMedica";
            Load += ClinicaMedica_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreM;
        private TextBox txtEspecialidadM;
        private TextBox txtContraseñaM;
        private TextBox txtEmailM;
        private TextBox txtApellidoM;
        private Button lblNuevoM;
        private Button lblGuardarM;
        private Button lblEditarM;
        private Button lblEliminarM;
        private DataGridView dataGridView1;
        private Button btnPacientes;
        private Button btnHistorial;
        private Button btnCitas;
        private Button btnMedicamentos;
        private Button button1;
        private Button button2;
        private Button btnUsuarios;
    }
}