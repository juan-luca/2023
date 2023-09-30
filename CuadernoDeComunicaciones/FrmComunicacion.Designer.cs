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
        private ComboBox cboCategoria;
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
            lblComunicacionNro = new Label();
            lblComunicacionNroValue = new Label();
            lblRemitente = new Label();
            lblRemitenteValue = new Label();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
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
            gbxDatos.Controls.Add(cboCategoria);
            gbxDatos.Controls.Add(lblTexto);
            gbxDatos.Controls.Add(txtTexto);
            gbxDatos.Location = new Point(16, 16);
            gbxDatos.Margin = new Padding(5, 3, 5, 3);
            gbxDatos.Padding = new Padding(5, 3, 5, 3);
            gbxDatos.Size = new Size(1056, 133);
            gbxDatos.Controls.SetChildIndex(txtTexto, 0);
            gbxDatos.Controls.SetChildIndex(lblTexto, 0);
            gbxDatos.Controls.SetChildIndex(cboCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblCategoria, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNroValue, 0);
            gbxDatos.Controls.SetChildIndex(lblComunicacionNro, 0);
            // 
            // lblComunicacionNro
            // 
            lblComunicacionNro.AutoSize = true;
            lblComunicacionNro.Location = new Point(242, 21);
            lblComunicacionNro.Margin = new Padding(4, 0, 4, 0);
            lblComunicacionNro.Name = "lblComunicacionNro";
            lblComunicacionNro.Size = new Size(151, 15);
            lblComunicacionNro.TabIndex = 6;
            lblComunicacionNro.Text = "Número de Comunicación:";
            // 
            // lblComunicacionNroValue
            // 
            lblComunicacionNroValue.Location = new Point(401, 17);
            lblComunicacionNroValue.Margin = new Padding(4, 3, 4, 3);
            lblComunicacionNroValue.Name = "lblComunicacionNroValue";
            lblComunicacionNroValue.Size = new Size(119, 23);
            lblComunicacionNroValue.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(242, 52);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(401, 55);
            cboCategoria.Margin = new Padding(4, 3, 4, 3);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(119, 23);
            cboCategoria.TabIndex = 9;
            cboCategoria.DataSource = Enum.GetValues(typeof(Categoria)).Cast<Categoria>().ToList();

            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(528, 17);
            lblTexto.Margin = new Padding(4, 0, 4, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(38, 15);
            lblTexto.TabIndex = 10;
            lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(574, 12);
            txtTexto.Margin = new Padding(4, 3, 4, 3);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(473, 115);
            txtTexto.TabIndex = 11;
            txtTexto.Text = "Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum";

            // 
            // FrmComunicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 599);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmComunicacion";
            Text = "Comunicación";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
