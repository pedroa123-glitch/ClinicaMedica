namespace ClinicaMedica.Presentacion
{
    partial class FrmHistorialClinico
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
            txtIdHistorial = new TextBox();
            txtPaciente = new TextBox();
            txtDiagnostico = new TextBox();
            txtFecha = new TextBox();
            txtMedico = new TextBox();
            dgHistorial = new DataGridView();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Historial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Medico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 9);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha Registro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 76);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Diagnostico:";
            // 
            // txtIdHistorial
            // 
            txtIdHistorial.Enabled = false;
            txtIdHistorial.Location = new Point(110, 9);
            txtIdHistorial.Name = "txtIdHistorial";
            txtIdHistorial.ReadOnly = true;
            txtIdHistorial.Size = new Size(224, 27);
            txtIdHistorial.TabIndex = 5;
            txtIdHistorial.TabStop = false;
            txtIdHistorial.TextChanged += txtIdHistorial_TextChanged;
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Location = new Point(110, 69);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(224, 27);
            txtPaciente.TabIndex = 6;
            txtPaciente.TabStop = false;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Enabled = false;
            txtDiagnostico.Location = new Point(508, 69);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ReadOnly = true;
            txtDiagnostico.ScrollBars = ScrollBars.Both;
            txtDiagnostico.Size = new Size(224, 27);
            txtDiagnostico.TabIndex = 7;
            txtDiagnostico.TabStop = false;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(508, 6);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(224, 27);
            txtFecha.TabIndex = 8;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Location = new Point(110, 137);
            txtMedico.Name = "txtMedico";
            txtMedico.ReadOnly = true;
            txtMedico.Size = new Size(224, 27);
            txtMedico.TabIndex = 9;
            txtMedico.TabStop = false;
            // 
            // dgHistorial
            // 
            dgHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHistorial.Location = new Point(22, 338);
            dgHistorial.Name = "dgHistorial";
            dgHistorial.RowHeadersWidth = 51;
            dgHistorial.Size = new Size(740, 188);
            dgHistorial.TabIndex = 10;
            dgHistorial.CellContentClick += dgHistorial_CellContentClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(273, 240);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(175, 74);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmHistorialClinico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(btnCerrar);
            Controls.Add(dgHistorial);
            Controls.Add(txtMedico);
            Controls.Add(txtFecha);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtPaciente);
            Controls.Add(txtIdHistorial);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHistorialClinico";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmHistorialClinico";
            Load += FrmHistorialClinico_Load;
            ((System.ComponentModel.ISupportInitialize)dgHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdHistorial;
        private TextBox txtPaciente;
        private TextBox txtDiagnostico;
        private TextBox txtFecha;
        private TextBox txtMedico;
        private DataGridView dgHistorial;
        private Button btnCerrar;
    }
}