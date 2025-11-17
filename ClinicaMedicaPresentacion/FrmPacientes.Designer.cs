namespace ClinicaMedicaPresentacion
{
    partial class FrmPacientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDNI = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            dtpFN = new DateTimePicker();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            cboGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 184);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 22);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 5;
            label5.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 67);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 6;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 125);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 7;
            label7.Text = "Genero:";
            label7.Click += label7_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(165, 19);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(181, 27);
            txtDNI.TabIndex = 8;
            txtDNI.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(519, 22);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 27);
            txtDireccion.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(165, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(181, 27);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(519, 64);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(181, 27);
            txtTelefono.TabIndex = 12;
            // 
            // dtpFN
            // 
            dtpFN.Format = DateTimePickerFormat.Short;
            dtpFN.Location = new Point(174, 179);
            dtpFN.Name = "dtpFN";
            dtpFN.Size = new Size(172, 27);
            dtpFN.TabIndex = 14;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(28, 230);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(143, 55);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 55);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(418, 230);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 55);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(628, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 55);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button4_Click;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(519, 121);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(181, 28);
            cboGenero.TabIndex = 19;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 557);
            Controls.Add(cboGenero);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dtpFN);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtDNI);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPaciente";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDNI;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private DateTimePicker dtpFN;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private ComboBox cboGenero;
    }
}
