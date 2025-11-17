namespace ClinicaMedica.Presentacion
{
    partial class FrmEstadisticas
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
            lblPacientes = new Label();
            lblMedicos = new Label();
            lblCitas = new Label();
            lblRecetas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Pacientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 77);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Medicos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Citas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 186);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Recetas:";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(171, 26);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(0, 20);
            lblPacientes.TabIndex = 4;
            lblPacientes.Click += label5_Click;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(171, 77);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(0, 20);
            lblMedicos.TabIndex = 5;
            // 
            // lblCitas
            // 
            lblCitas.AutoSize = true;
            lblCitas.Location = new Point(171, 124);
            lblCitas.Name = "lblCitas";
            lblCitas.Size = new Size(0, 20);
            lblCitas.TabIndex = 6;
            // 
            // lblRecetas
            // 
            lblRecetas.AutoSize = true;
            lblRecetas.Location = new Point(171, 186);
            lblRecetas.Name = "lblRecetas";
            lblRecetas.Size = new Size(0, 20);
            lblRecetas.TabIndex = 7;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(lblRecetas);
            Controls.Add(lblCitas);
            Controls.Add(lblMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblPacientes;
        private Label lblMedicos;
        private Label lblCitas;
        private Label lblRecetas;
    }
}