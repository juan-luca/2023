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
            gbxDatos.Location = new Point(16, 16);
            gbxDatos.Margin = new Padding(5, 3, 5, 3);
            gbxDatos.Padding = new Padding(5, 3, 5, 3);
            gbxDatos.Size = new Size(1058, 172);
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
            lblCalificacionNro.Location = new Point(242, 21);
            lblCalificacionNro.Margin = new Padding(4, 0, 4, 0);
            lblCalificacionNro.Name = "lblCalificacionNro";
            lblCalificacionNro.Size = new Size(138, 15);
            lblCalificacionNro.TabIndex = 6;
            lblCalificacionNro.Text = "Número de Calificación:";
            // 
            // lblCalificacionNroValue
            // 
            lblCalificacionNroValue.BackColor = Color.Transparent;
            lblCalificacionNroValue.Location = new Point(401, 17);
            lblCalificacionNroValue.Margin = new Padding(4, 3, 4, 3);
            lblCalificacionNroValue.Name = "lblCalificacionNroValue";
            lblCalificacionNroValue.Size = new Size(119, 23);
            lblCalificacionNroValue.TabIndex = 7;
            lblCalificacionNroValue.TextChanged += lblCalificacionNroValue_TextChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Location = new Point(242, 52);
            lblMateria.Margin = new Padding(4, 0, 4, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(53, 15);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "Materia:";
            // 
            // CboMateria
            // 
            CboMateria.BackColor = Color.LightGray;
           CboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CboMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CboMateria.ForeColor = Color.White;
            CboMateria.FormattingEnabled = true;
          CboMateria.Location = new Point(401, 55);
            CboMateria.Margin = new Padding(4, 3, 4, 3);
            CboMateria.Name = "CboMateria";
            CboMateria.Size = new Size(119, 23);
            CboMateria.TabIndex = 9;
            CboMateria.DataSource = Enum.GetValues(typeof(Categoria));
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.BackColor = Color.Transparent;
            lblNota.Location = new Point(543, 21);
            lblNota.Margin = new Padding(4, 0, 4, 0);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(37, 15);
            lblNota.TabIndex = 10;
            lblNota.Text = "Nota:";
            // 
            // nuNota
            // 
            nuNota.BackColor = Color.LightGray;
            nuNota.Cursor = Cursors.Hand;
            nuNota.ForeColor = Color.White;
            nuNota.Location = new Point(591, 17);
            nuNota.Margin = new Padding(4, 3, 4, 3);
            nuNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nuNota.Name = "nuNota";
            nuNota.Size = new Size(53, 23);
            nuNota.TabIndex = 11;
            nuNota.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Transparent;
            lblObservaciones.Location = new Point(543, 52);
            lblObservaciones.Margin = new Padding(4, 0, 4, 0);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(91, 15);
            lblObservaciones.TabIndex = 12;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.LightGray;
            txtObservaciones.Cursor = Cursors.Hand;
            txtObservaciones.ForeColor = Color.White;
            txtObservaciones.Location = new Point(662, 47);
            txtObservaciones.Margin = new Padding(4, 3, 4, 3);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(303, 68);
            txtObservaciones.TabIndex = 13;
            txtObservaciones.Text = resources.GetString("txtObservaciones.Text");
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.BackColor = Color.Transparent;
            lblConcepto.Location = new Point(242, 88);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(60, 15);
            lblConcepto.TabIndex = 14;
            lblConcepto.Text = "Concepto";
            // 
            // txtConcepto
            // 
            txtConcepto.BackColor = Color.LightGray;
            txtConcepto.Cursor = Cursors.Hand;
            txtConcepto.ForeColor = Color.White;
            txtConcepto.Location = new Point(402, 92);
            txtConcepto.Margin = new Padding(3, 2, 3, 2);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(118, 23);
            txtConcepto.TabIndex = 15;
            txtConcepto.Text = "Conceptual";
            // 
            // FrmCalificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 599);
            Fecha = new DateTime(2023, 9, 30, 18, 56, 35, 845);
            Margin = new Padding(5, 3, 5, 3);
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
