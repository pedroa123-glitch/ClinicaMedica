namespace ClinicaMedica.Presentacion
{
    partial class FrmUsuarios
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
            dgUsuarios = new DataGridView();
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(60, 250);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowHeadersWidth = 51;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(661, 188);
            dgUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 83);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "Rol:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(157, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(301, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(559, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(162, 59);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(559, 123);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(162, 59);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(dgUsuarios);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCerrar;
    }
}