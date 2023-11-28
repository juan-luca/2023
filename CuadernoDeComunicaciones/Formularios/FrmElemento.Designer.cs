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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
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
            btnLimpiar = new Button();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElementos).BeginInit();
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
            gbxDatos.FlatStyle = FlatStyle.Flat;
            gbxDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbxDatos.ForeColor = Color.White;
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
            cboAlumno.BackColor = Color.Orange;
            cboAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cboAlumno.ForeColor = Color.White;
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
            lblAlumno.BackColor = Color.Transparent;
            lblAlumno.FlatStyle = FlatStyle.Flat;
            lblAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlumno.ForeColor = Color.White;
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
            dtpFecha.CalendarForeColor = Color.Transparent;
            dtpFecha.CalendarMonthBackground = Color.Transparent;
            dtpFecha.CalendarTitleBackColor = Color.Transparent;
            dtpFecha.CalendarTitleForeColor = Color.Transparent;
            dtpFecha.CalendarTrailingForeColor = Color.Transparent;
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
            lblFecha.BackColor = Color.Transparent;
            lblFecha.FlatStyle = FlatStyle.Flat;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(7, 48);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(42, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblRemitenteValue
            // 
            lblRemitenteValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRemitenteValue.BackColor = Color.Transparent;
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
            lblRemitente.BackColor = Color.Transparent;
            lblRemitente.FlatStyle = FlatStyle.Flat;
            lblRemitente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemitente.ForeColor = Color.White;
            lblRemitente.Location = new Point(7, 18);
            lblRemitente.Margin = new Padding(4, 0, 4, 0);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(70, 15);
            lblRemitente.TabIndex = 0;
            lblRemitente.Text = "Remitente:";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(14, 158);
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
            btnModificar.BackColor = Color.Transparent;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(108, 158);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(203, 158);
            btnBorrar.Margin = new Padding(4, 3, 4, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(88, 27);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Transparent;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.ForeColor = Color.White;
            btnListar.Location = new Point(298, 158);
            btnListar.Margin = new Padding(4, 3, 4, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 27);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // dgvElementos
            // 
            dgvElementos.AllowUserToAddRows = false;
            dgvElementos.AllowUserToDeleteRows = false;
            dgvElementos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElementos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvElementos.BackgroundColor = Color.Orange;
            dgvElementos.BorderStyle = BorderStyle.None;
            dgvElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElementos.GridColor = SystemColors.ControlLight;
            dgvElementos.Location = new Point(14, 192);
            dgvElementos.Margin = new Padding(4, 3, 4, 3);
            dgvElementos.MultiSelect = false;
            dgvElementos.Name = "dgvElementos";
            dgvElementos.ReadOnly = true;
            dgvElementos.RowHeadersWidth = 51;
            dgvElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementos.Size = new Size(905, 314);
            dgvElementos.TabIndex = 10;
            dgvElementos.CellClick += dgvElementos_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(396, 157);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 27);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnLimpiar);
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
            ResumeLayout(false);
        }

        #endregion


        private Button btnLimpiar;
    }
}