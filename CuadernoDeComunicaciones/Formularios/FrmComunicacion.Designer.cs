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
            gbxDatos.Size = new Size(1034, 177);
            gbxDatos.Controls.SetChildIndex(txtTexto, 0);
            gbxDatos.Controls.SetChildIndex(lblTexto, 0);
            gbxDatos.Controls.SetChildIndex(CboCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNroValue, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNro, 0);
            // 
            // lblComunicacionNro
            // 
            lblComunicacionNro.AutoSize = true;
            lblComunicacionNro.BackColor = Color.Transparent;
            lblComunicacionNro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComunicacionNro.ForeColor = Color.White;
            lblComunicacionNro.Location = new Point(277, 28);
            lblComunicacionNro.Margin = new Padding(5, 0, 5, 0);
            lblComunicacionNro.Name = "lblComunicacionNro";
            lblComunicacionNro.Size = new Size(194, 20);
            lblComunicacionNro.TabIndex = 6;
            lblComunicacionNro.Text = "Número de Comunicación:";
            // 
            // lblComunicacionNroValue
            // 
            lblComunicacionNroValue.BackColor = Color.Transparent;
            lblComunicacionNroValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComunicacionNroValue.ForeColor = Color.White;
            lblComunicacionNroValue.Location = new Point(458, 23);
            lblComunicacionNroValue.Margin = new Padding(5, 4, 5, 4);
            lblComunicacionNroValue.Name = "lblComunicacionNroValue";
            lblComunicacionNroValue.Size = new Size(136, 31);
            lblComunicacionNroValue.TabIndex = 7;
            lblComunicacionNroValue.TextChanged += lblComunicacionNroValue_TextChanged;
            
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.FlatStyle = FlatStyle.Flat;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(277, 69);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoría:";
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
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.BackColor = Color.Transparent;
            lblTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.ForeColor = Color.White;
            lblTexto.Location = new Point(603, 23);
            lblTexto.Margin = new Padding(5, 0, 5, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(52, 20);
            lblTexto.TabIndex = 10;
            lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            txtTexto.BackColor = Color.Orange;
            txtTexto.BorderStyle = BorderStyle.None;
            txtTexto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTexto.ForeColor = Color.White;
            txtTexto.Location = new Point(656, 16);
            txtTexto.Margin = new Padding(5, 4, 5, 4);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(540, 152);
            txtTexto.TabIndex = 11;
            txtTexto.Text = resources.GetString("txtTexto.Text");
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
            BtnCrearClick += FrmElemento_BtnCrearClick;
            BtnModificarClick += FrmElemento_BtnModificarClick;
            BtnBorrarClick += FrmElemento_BtnBorrarClick;
            BtnListarClick += FrmElemento_BtnListarClick;
            BtnLimpiarClick += FrmElemento_BtnLimpiarClick;
            dgvElementosCellClick += FrmElemento_dgvElementosCellClick;
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ResumeLayout(false);
        }
    }
}



