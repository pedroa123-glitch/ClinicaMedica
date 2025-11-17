namespace ClinicaMedica.Presentacion
{
    partial class FrmMedicamentos
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
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgMedicamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(150, 135);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(306, 27);
            txtStock.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(159, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(297, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 216);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(134, 59);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(195, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 59);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar ";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(376, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 59);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(559, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 59);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgMedicamentos
            // 
            dgMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicamentos.Location = new Point(12, 309);
            dgMedicamentos.Name = "dgMedicamentos";
            dgMedicamentos.RowHeadersWidth = 51;
            dgMedicamentos.Size = new Size(776, 129);
            dgMedicamentos.TabIndex = 10;
            dgMedicamentos.CellContentClick += dgMedicamentos_CellContentClick;
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgMedicamentos);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMedicamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMedicamentos";
            Load += FrmMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgMedicamentos;
    }
}