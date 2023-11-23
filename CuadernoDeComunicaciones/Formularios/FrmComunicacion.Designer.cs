using BibliotecaClases;

namespace CuadernoDeComunicaciones
{
    partial class FrmComunicacion : FrmElemento
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblComunicacionNro;
        private Label lblComunicacionNroValue;
        private Label lblRemitente;
        private Label lblRemitenteValue;

        private Label lblCategoria;
        private ComboBox CboCategoria;
        private Label lblTexto;
        private TextBox txtTexto;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComunicacion));
            lblComunicacionNro = new Label();
            lblComunicacionNroValue = new Label();
            lblRemitente = new Label();
            lblRemitenteValue = new Label();
            lblCategoria = new Label();
            CboCategoria = new ComboBox();
            lblTexto = new Label();
            txtTexto = new TextBox();
            gbxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(lblComunicacionNro);
            gbxDatos.Controls.Add(lblComunicacionNroValue);
            gbxDatos.Controls.Add(lblCategoria);
            gbxDatos.Controls.Add(CboCategoria);
            gbxDatos.Controls.Add(lblTexto);
            gbxDatos.Controls.Add(txtTexto);
            gbxDatos.Location = new Point(18, 21);
            gbxDatos.Margin = new Padding(6, 4, 6, 4);
            gbxDatos.Padding = new Padding(6, 4, 6, 4);
            gbxDatos.Size = new Size(1182, 177);
            gbxDatos.Controls.SetChildIndex(txtTexto, 0);
            gbxDatos.Controls.SetChildIndex(lblTexto, 0);
            gbxDatos.Controls.SetChildIndex(CboCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNroValue, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNro, 0);
            // Configuración de lblComunicacionNro
            lblComunicacionNro.AutoSize = true;
            lblComunicacionNro.Location = new Point(277, 28);
            lblComunicacionNro.Margin = new Padding(5, 0, 5, 0);
            lblComunicacionNro.Name = "lblComunicacionNro";
            lblComunicacionNro.Size = new Size(185, 20);
            lblComunicacionNro.TabIndex = 6;
            lblComunicacionNro.Text = "Número de Comunicación:";
            lblComunicacionNro.BackColor = Color.Transparent;
            lblComunicacionNro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComunicacionNro.ForeColor = Color.White;

            // Configuración de lblComunicacionNroValue
            lblComunicacionNroValue.Location = new Point(458, 23);
            lblComunicacionNroValue.Margin = new Padding(5, 4, 5, 4);
            lblComunicacionNroValue.Name = "lblComunicacionNroValue";
            lblComunicacionNroValue.Size = new Size(136, 31);
            lblComunicacionNroValue.TabIndex = 7;
            lblComunicacionNroValue.TextChanged += lblComunicacionNroValue_TextChanged;
            lblComunicacionNroValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComunicacionNroValue.BackColor = Color.Transparent;
            lblComunicacionNroValue.ForeColor = Color.White;


            // Configuración de lblCategoria
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(277, 69);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoría:";
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.FlatStyle = FlatStyle.Flat;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.White;

            // Configuración de CboCategoria
            CboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCategoria.FormattingEnabled = true;
            CboCategoria.Location = new Point(458, 73);
            CboCategoria.Margin = new Padding(5, 4, 5, 4);
            CboCategoria.Name = "CboCategoria";
            CboCategoria.Size = new Size(135, 28);
            CboCategoria.TabIndex = 9;
            CboCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            CboCategoria.BackColor = Color.White;
            CboCategoria.ForeColor = Color.Black;

            // Configuración de lblTexto
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(603, 23);
            lblTexto.Margin = new Padding(5, 0, 5, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(48, 20);
            lblTexto.TabIndex = 10;
            lblTexto.Text = "Texto:";
            lblTexto.BackColor = Color.Transparent;
            lblTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.ForeColor = Color.White;

            // Configuración de txtTexto
            txtTexto.Location = new Point(656, 16);
            txtTexto.Margin = new Padding(5, 4, 5, 4);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(540, 152);
            txtTexto.TabIndex = 11;
            txtTexto.Text = resources.GetString("txtTexto.Text");
            txtTexto.BackColor = Color.White;
            txtTexto.ForeColor = Color.Black;

            this.BtnCrearClick += FrmElemento_BtnCrearClick;
            this.BtnModificarClick += FrmElemento_BtnModificarClick;
            this.BtnBorrarClick += FrmElemento_BtnBorrarClick;
            this.BtnListarClick += FrmElemento_BtnListarClick;
            this.BtnLimpiarClick += FrmElemento_BtnLimpiarClick;
            this.dgvElementosCellClick += FrmElemento_dgvElementosCellClick;
            this.Listar();
            // 
            // FrmComunicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 799);
            Fecha = new DateTime(2023, 9, 30, 18, 56, 35, 845);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FrmComunicacion";
            Text = "Comunicación";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}



