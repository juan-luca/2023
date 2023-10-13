using MetroSet_UI.Forms;
namespace CuadernoDeComunicaciones
{
    partial class FrmPrincipal : MetroSetForm
    {

        private System.ComponentModel.IContainer components = null;

        private Button btnComunicaciones;
        private Button btnCalificaciones;
        private Button btnPerfiles;
        private Panel pnlElemento;

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
            btnComunicaciones = new Button();
            btnCalificaciones = new Button();
            btnPerfiles = new Button();
            pnlElemento = new Panel();
            SuspendLayout();
            // 
            // btnComunicaciones
            // 
            btnComunicaciones.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnComunicaciones.Location = new Point(116, 208);
            btnComunicaciones.Margin = new Padding(4);
            btnComunicaciones.Name = "btnComunicaciones";
            btnComunicaciones.Size = new Size(294, 62);
            btnComunicaciones.TabIndex = 0;
            btnComunicaciones.Text = "Comunicaciones";
            btnComunicaciones.UseVisualStyleBackColor = true;
            btnComunicaciones.Click += btnComunicaciones_Click;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalificaciones.Location = new Point(899, 208);
            btnCalificaciones.Margin = new Padding(4);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(294, 62);
            btnCalificaciones.TabIndex = 1;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = true;
            btnCalificaciones.Click += btnCalificaciones_Click;
            // 
            // btnPerfiles
            // 
            btnPerfiles.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfiles.Location = new Point(471, 208);
            btnPerfiles.Margin = new Padding(4);
            btnPerfiles.Name = "btnPerfiles";
            btnPerfiles.Size = new Size(375, 62);
            btnPerfiles.TabIndex = 2;
            btnPerfiles.Text = "Perfiles";
            btnPerfiles.UseVisualStyleBackColor = true;
            btnPerfiles.Click += btnPerfiles_Click;
            // 
            // pnlElemento
            // 
            pnlElemento.Dock = DockStyle.Fill; // Esto ajusta automáticamente el panel al tamaño del formulario
            pnlElemento.Location = new Point(8, 333);
            pnlElemento.Name = "pnlElemento";
            pnlElemento.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1282, 748);
            Controls.Add(pnlElemento);
            Controls.Add(btnPerfiles);
            Controls.Add(btnCalificaciones);
            Controls.Add(btnComunicaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuaderno de Comunicaciones";
            ResumeLayout(false);
        }

        #endregion


    }
}