using BibliotecaClases;

namespace CuadernoDeComunicaciones
{
    partial class FrmCalificacion : FrmElemento
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCalificacionNro;
        private Label lblCalificacionNroValue;
        private Label lblMateria;
        private ComboBox CboMateria;
        private Label lblNota;
        private NumericUpDown nuNota;
        private Label lblObservaciones;
        private TextBox txtObservaciones;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalificacion));
            lblCalificacionNro = new Label();
            lblCalificacionNroValue = new Label();
            lblMateria = new Label();
            CboMateria = new ComboBox();
            lblNota = new Label();
            nuNota = new NumericUpDown();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            lblConcepto = new Label();
            txtConcepto = new TextBox();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuNota).BeginInit();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.BackgroundImage = (Image)resources.GetObject("gbxDatos.BackgroundImage");
            gbxDatos.Controls.Add(txtConcepto);
            gbxDatos.Controls.Add(lblConcepto);
            gbxDatos.Controls.Add(lblCalificacionNro);
            gbxDatos.Controls.Add(lblCalificacionNroValue);
            gbxDatos.Controls.Add(lblMateria);
            gbxDatos.Controls.Add(CboMateria);
            gbxDatos.Controls.Add(lblNota);
            gbxDatos.Controls.Add(nuNota);
            gbxDatos.Controls.Add(lblObservaciones);
            gbxDatos.Controls.Add(txtObservaciones);
            gbxDatos.Location = new Point(18, 21);
            gbxDatos.Margin = new Padding(6, 4, 6, 4);
            gbxDatos.Padding = new Padding(6, 4, 6, 4);
            gbxDatos.Size = new Size(1034, 177);
            gbxDatos.Controls.SetChildIndex(txtObservaciones, 0);
            gbxDatos.Controls.SetChildIndex(lblObservaciones, 0);
            gbxDatos.Controls.SetChildIndex(nuNota, 0);
            gbxDatos.Controls.SetChildIndex(lblNota, 0);
            gbxDatos.Controls.SetChildIndex(CboMateria, 0);
            gbxDatos.Controls.SetChildIndex(lblMateria, 0);
            gbxDatos.Controls.SetChildIndex(lblCalificacionNroValue, 0);
            gbxDatos.Controls.SetChildIndex(lblCalificacionNro, 0);
            gbxDatos.Controls.SetChildIndex(lblConcepto, 0);
            gbxDatos.Controls.SetChildIndex(txtConcepto, 0);
            // 
            // lblCalificacionNro
            // 
            lblCalificacionNro.AutoSize = true;
            lblCalificacionNro.BackColor = Color.Transparent;
            lblCalificacionNro.Location = new Point(277, 28);
            lblCalificacionNro.Margin = new Padding(5, 0, 5, 0);
            lblCalificacionNro.Name = "lblCalificacionNro";
            lblCalificacionNro.Size = new Size(175, 20);
            lblCalificacionNro.TabIndex = 6;
            lblCalificacionNro.Text = "Número de Calificación:";
            // 
            // lblCalificacionNroValue
            // 
            lblCalificacionNroValue.BackColor = Color.Transparent;
            lblCalificacionNroValue.Location = new Point(458, 23);
            lblCalificacionNroValue.Margin = new Padding(5, 4, 5, 4);
            lblCalificacionNroValue.Name = "lblCalificacionNroValue";
            lblCalificacionNroValue.Size = new Size(136, 31);
            lblCalificacionNroValue.TabIndex = 7;
            lblCalificacionNroValue.TextChanged += lblCalificacionNroValue_TextChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Location = new Point(277, 69);
            lblMateria.Margin = new Padding(5, 0, 5, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(67, 20);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "Materia:";
            // 
            // CboMateria
            // 
            CboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CboMateria.FormattingEnabled = true;
            CboMateria.Location = new Point(458, 73);
            CboMateria.Margin = new Padding(5, 4, 5, 4);
            CboMateria.Name = "CboMateria";
            CboMateria.Size = new Size(135, 28);
            CboMateria.TabIndex = 9;
            CboMateria.DataSource = Enum.GetValues(typeof(Materia));
            CboMateria.BackColor = Color.Orange;
            CboMateria.ForeColor = Color.White;
            CboMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.BackColor = Color.Transparent;
            lblNota.Location = new Point(621, 28);
            lblNota.Margin = new Padding(5, 0, 5, 0);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(48, 20);
            lblNota.TabIndex = 10;
            lblNota.Text = "Nota:";
            // 
            // nuNota
            // 
            nuNota.BackColor = Color.Orange;
            nuNota.Cursor = Cursors.Hand;
            nuNota.ForeColor = Color.White;
            nuNota.Location = new Point(675, 23);
            nuNota.Margin = new Padding(5, 4, 5, 4);
            nuNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nuNota.Name = "nuNota";
            nuNota.Size = new Size(61, 27);
            nuNota.TabIndex = 11;
            nuNota.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Transparent;
            lblObservaciones.Location = new Point(621, 69);
            lblObservaciones.Margin = new Padding(5, 0, 5, 0);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(115, 20);
            lblObservaciones.TabIndex = 12;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.Orange;
            txtObservaciones.Cursor = Cursors.Hand;
            txtObservaciones.ForeColor = Color.White;
            txtObservaciones.Location = new Point(757, 63);
            txtObservaciones.Margin = new Padding(5, 4, 5, 4);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(254, 89);
            txtObservaciones.TabIndex = 13;
            txtObservaciones.Text = resources.GetString("txtObservaciones.Text");
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.BackColor = Color.Transparent;
            lblConcepto.Location = new Point(277, 118);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(75, 20);
            lblConcepto.TabIndex = 14;
            lblConcepto.Text = "Concepto";
            // 
            // txtConcepto
            // 
            txtConcepto.BackColor = Color.Orange;
            txtConcepto.Cursor = Cursors.Hand;
            txtConcepto.ForeColor = Color.White;
            txtConcepto.Location = new Point(459, 122);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(134, 27);
            txtConcepto.TabIndex = 15;
            txtConcepto.Text = "Conceptual";

            this.Listar();
            // 
            // FrmCalificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1243, 799);
            Fecha = new DateTime(2023, 9, 30, 18, 56, 35, 845);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FrmCalificacion";
            Text = "Calificación";
            BtnCrearClick += FrmElemento_BtnCrearClick;
            BtnModificarClick += FrmElemento_BtnModificarClick;
            BtnBorrarClick += FrmElemento_BtnBorrarClick;
            BtnListarClick += FrmElemento_BtnListarClick;
            BtnLimpiarClick += FrmElemento_BtnLimpiarClick;
            dgvElementosCellClick += FrmElemento_dgvElementosCellClick;
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuNota).EndInit();
            ResumeLayout(false);
        }

        private Label lblConcepto;
        private TextBox txtConcepto;
    }
}
