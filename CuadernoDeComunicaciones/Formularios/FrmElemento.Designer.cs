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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElemento));
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
            gbxDatos.BackgroundImage = (Image)resources.GetObject("gbxDatos.BackgroundImage");
            gbxDatos.Controls.Add(cboAlumno);
            gbxDatos.Controls.Add(lblAlumno);
            gbxDatos.Controls.Add(dtpFecha);
            gbxDatos.Controls.Add(lblFecha);
            gbxDatos.Controls.Add(lblRemitenteValue);
            gbxDatos.Controls.Add(lblRemitente);
            gbxDatos.Location = new Point(16, 19);
            gbxDatos.Margin = new Padding(5, 4, 5, 4);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Padding = new Padding(5, 4, 5, 4);
            gbxDatos.Size = new Size(1034, 153);
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
            cboAlumno.Location = new Point(85, 101);
            cboAlumno.Margin = new Padding(5, 4, 5, 4);
            cboAlumno.Name = "cboAlumno";
            cboAlumno.Size = new Size(141, 28);
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
            lblAlumno.Location = new Point(8, 104);
            lblAlumno.Margin = new Padding(5, 0, 5, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(69, 20);
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
            dtpFecha.Location = new Point(85, 60);
            dtpFecha.Margin = new Padding(5, 4, 5, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(141, 27);
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
            lblFecha.Location = new Point(8, 64);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblRemitenteValue
            // 
            lblRemitenteValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRemitenteValue.BackColor = Color.Transparent;
            lblRemitenteValue.Location = new Point(85, 23);
            lblRemitenteValue.Margin = new Padding(5, 4, 5, 4);
            lblRemitenteValue.Name = "lblRemitenteValue";
            lblRemitenteValue.Size = new Size(142, 31);
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
            lblRemitente.Location = new Point(8, 24);
            lblRemitente.Margin = new Padding(5, 0, 5, 0);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(86, 20);
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
            btnCrear.Location = new Point(16, 181);
            btnCrear.Margin = new Padding(5, 4, 5, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 36);
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
            btnModificar.Location = new Point(123, 181);
            btnModificar.Margin = new Padding(5, 4, 5, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(101, 36);
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
            btnBorrar.Location = new Point(232, 181);
            btnBorrar.Margin = new Padding(5, 4, 5, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 36);
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
            btnListar.Location = new Point(341, 181);
            btnListar.Margin = new Padding(5, 4, 5, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(101, 36);
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
            dgvElementos.Location = new Point(16, 227);
            dgvElementos.Margin = new Padding(5, 4, 5, 4);
            dgvElementos.MultiSelect = false;
            dgvElementos.Name = "dgvElementos";
            dgvElementos.ReadOnly = true;
            dgvElementos.RowHeadersWidth = 51;
            dgvElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementos.Size = new Size(1034, 419);
            dgvElementos.TabIndex = 10;
            dgvElementos.CellClick += dgvElementos_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(452, 180);
            btnLimpiar.Margin = new Padding(5, 4, 5, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 36);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmElemento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1066, 692);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvElementos);
            Controls.Add(btnListar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(gbxDatos);
            Margin = new Padding(5, 4, 5, 4);
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