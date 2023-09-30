namespace CuadernoDeComunicaciones
{
    partial class FrmElemento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected GroupBox gbxDatos;
        private ComboBox cboAlumno;
        private Label lblAlumno;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblRemitenteValue;
        private Label lblRemitente;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnListar;
        private DataGridView dgvElementos;
        private StatusStrip statusStrip1;
        private ToolStripTextBox txtBuscar;
        private ErrorProvider errorProvider1;

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
            components = new System.ComponentModel.Container();
            gbxDatos = new GroupBox();
            cboAlumno = new ComboBox();
            lblAlumno = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblRemitenteValue = new Label();
            lblRemitente = new Label();
            btnCrear = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnListar = new Button();
            dgvElementos = new DataGridView();
            statusStrip1 = new StatusStrip();
            txtBuscar = new ToolStripTextBox();
            errorProvider1 = new ErrorProvider(components);
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElementos).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxDatos.Controls.Add(cboAlumno);
            gbxDatos.Controls.Add(lblAlumno);
            gbxDatos.Controls.Add(dtpFecha);
            gbxDatos.Controls.Add(lblFecha);
            gbxDatos.Controls.Add(lblRemitenteValue);
            gbxDatos.Controls.Add(lblRemitente);
            gbxDatos.Location = new Point(14, 14);
            gbxDatos.Margin = new Padding(4, 3, 4, 3);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Padding = new Padding(4, 3, 4, 3);
            gbxDatos.Size = new Size(905, 115);
            gbxDatos.TabIndex = 0;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // cboAlumno
            // 
            cboAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlumno.FormattingEnabled = true;
            cboAlumno.Location = new Point(74, 76);
            cboAlumno.Margin = new Padding(4, 3, 4, 3);
            cboAlumno.Name = "cboAlumno";
            cboAlumno.Size = new Size(124, 23);
            cboAlumno.TabIndex = 12;
            // 
            // lblAlumno
            // 
            lblAlumno.Anchor = AnchorStyles.Left;
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(7, 78);
            lblAlumno.Margin = new Padding(4, 0, 4, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(53, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "Alumno:";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left;
            dtpFecha.Location = new Point(74, 45);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(124, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(7, 48);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblRemitenteValue
            // 
            lblRemitenteValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRemitenteValue.Location = new Point(74, 17);
            lblRemitenteValue.Margin = new Padding(4, 3, 4, 3);
            lblRemitenteValue.Name = "lblRemitenteValue";
            lblRemitenteValue.Size = new Size(124, 23);
            lblRemitenteValue.TabIndex = 1;
            // 
            // lblRemitente
            // 
            lblRemitente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRemitente.AutoSize = true;
            lblRemitente.Location = new Point(7, 18);
            lblRemitente.Margin = new Padding(4, 0, 4, 0);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(64, 15);
            lblRemitente.TabIndex = 0;
            lblRemitente.Text = "Remitente:";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.PaleGreen;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(14, 136);
            btnCrear.Margin = new Padding(4, 3, 4, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(88, 27);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(108, 136);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(203, 136);
            btnBorrar.Margin = new Padding(4, 3, 4, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(88, 27);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(298, 136);
            btnListar.Margin = new Padding(4, 3, 4, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 27);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvElementos
            // 
            dgvElementos.AllowUserToAddRows = false;
            dgvElementos.AllowUserToDeleteRows = false;
            dgvElementos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElementos.Location = new Point(14, 170);
            dgvElementos.Margin = new Padding(4, 3, 4, 3);
            dgvElementos.MultiSelect = false;
            dgvElementos.Name = "dgvElementos";
            dgvElementos.ReadOnly = true;
            dgvElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementos.Size = new Size(905, 314);
            dgvElementos.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtBuscar });
            statusStrip1.Location = new Point(0, 496);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(933, 23);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtBuscar
            // 
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(116, 23);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(statusStrip1);
            Controls.Add(dgvElementos);
            Controls.Add(btnListar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(gbxDatos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmElemento";
            Text = "Elemento";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElementos).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


    }
}