namespace CuadernoDeComunicaciones.Formularios
{
    partial class FrmPerfiles
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvUsuarios;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private ComboBox cboPerfil;
        private ComboBox cboPadre;
        private ComboBox cboMadre;
        private TextBox txtNombreCompleto;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblMadre;
        private Label lblPadre;
        private Label lblNombreUsuario;
        private Label lblContraseña;
        private Label lblPerfil;
        private Label lblNombreCompleto;

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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblPadre = new System.Windows.Forms.Label();
            this.lblMadre = new System.Windows.Forms.Label();
            this.cboPadre = new System.Windows.Forms.ComboBox();
            this.cboMadre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(600, 300);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += DgvUsuarios_CellClick;
            this.usuarios = Usuario.ListarTodos();

            this.dgvUsuarios.DataSource = this.usuarios;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(640, 26);

            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += TxtNombreUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(640, 66);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(640, 106);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(200, 21);
            this.cboPerfil.TabIndex = 3;
            this.cboPerfil.DataSource = Enum.GetValues(typeof(Perfil));
            this.cboPerfil.SelectedIndexChanged += cboPerfil_SelectedIndexChanged;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(640, 146);

            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCompleto.TabIndex = 4;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(640, 305);
            btnCrear.Margin = new Padding(4, 3, 4, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(88, 27);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(790, 305);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(640, 342);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnBorrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(790, 342);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 27);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // lblNombreUsuario
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(640, 12);

            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(97, 13);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "Nombre de Usuario";

            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(640, 52);

            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña";


            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(640, 92);

            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfil";

            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(640, 132);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(92, 13);
            this.lblNombreCompleto.TabIndex = 12;
            this.lblNombreCompleto.Text = "Nombre Completo";


            //
            // lblPadre
            // 
            lblPadre.AutoSize = true;
            lblPadre.Location = new Point(640, 197);
            lblPadre.Margin = new Padding(5, 0, 5, 0);
            lblPadre.Name = "lblPadre";
            lblPadre.Size = new Size(37, 15);
            lblPadre.TabIndex = 14;
            lblPadre.Text = "Padre";
            this.lblPadre.Visible = false;
            // 
            // lblMadre
            // 
            lblMadre.AutoSize = true;
            lblMadre.Location = new Point(640, 249);
            lblMadre.Margin = new Padding(5, 0, 5, 0);
            lblMadre.Name = "lblMadre";
            lblMadre.Size = new Size(41, 15);
            lblMadre.TabIndex = 16;
            lblMadre.Text = "Madre";
            this.lblMadre.Visible = false;
            // 
            // cboPadre
            // 
            cboPadre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPadre.FormattingEnabled = true;
            cboPadre.Location = new Point(640, 215);
            cboPadre.Margin = new Padding(5, 3, 5, 3);
            cboPadre.Name = "cboPadre";
            cboPadre.Size = new Size(233, 23);
            cboPadre.TabIndex = 13;
            this.cboPadre.Visible = false;
            // 
            // cboMadre
            // 
            cboMadre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMadre.FormattingEnabled = true;
            cboMadre.Location = new Point(640, 267);
            cboMadre.Margin = new Padding(5, 3, 5, 3);
            cboMadre.Name = "cboMadre";
            cboMadre.Size = new Size(235, 23);
            cboMadre.TabIndex = 15;
            this.cboMadre.Visible = false;


            this.padres = usuarios.Where(u => u.Perfil == "Padres").ToList();
            this.madres = usuarios.Where(u => u.Perfil == "Padres").ToList();
            padres.Insert(0, new Usuario { NombreUsuario = "Sin Seleccionar" });
            madres.Insert(0, new Usuario { NombreUsuario = "Sin Seleccionar" });

            
            cboPadre.DisplayMember = "NombreUsuario";
            cboPadre.ValueMember = "NombreUsuario";
            cboPadre.DataSource = padres;

            cboMadre.DisplayMember = "NombreUsuario";
            cboMadre.ValueMember = "NombreUsuario";
            cboMadre.DataSource = madres;
            

            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 327);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.lblMadre);
            this.Controls.Add(this.cboMadre);
            this.Controls.Add(this.cboPadre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.dgvUsuarios);
            
            this.Name = "FrmPerfiles";
            this.Text = "Perfiles de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        




        #endregion
    }
}
