namespace ClinicaMedica.Presentacion
{
    partial class FrmReportes
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnBuscar = new Button();
            dgvReportes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 129);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha Fin:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(170, 27);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(170, 129);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(530, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 83);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(12, 232);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(741, 206);
            dgvReportes.TabIndex = 5;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReportes);
            Controls.Add(btnBuscar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnBuscar;
        private DataGridView dgvReportes;
    }
}