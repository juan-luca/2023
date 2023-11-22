using CuadernoDeComunicaciones.Properties;

namespace CuadernoDeComunicaciones
{
    partial class FrmPrincipal
    {

        private System.ComponentModel.IContainer components = null;

        private Button btnComunicaciones;
        private Button btnCalificaciones;
        private Button btnPerfiles;
        private Panel pnlElemento;
        private Image BtnImg;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public void MouseLeave(string boton)
        {
            switch (boton)
            {
                case "COMU":
                    btnComunicaciones.BackgroundImage = BtnImg;
                    break;
                case "P":
                    btnPerfiles.BackgroundImage = BtnImg;
                    break;
                case "CALI":
                    btnCalificaciones.BackgroundImage = BtnImg;
                    break;
            }


        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnComunicaciones = new Button();
            btnCalificaciones = new Button();
            btnPerfiles = new Button();
            pnlElemento = new Panel();
            SuspendLayout();
            // 
            // btnComunicaciones
            // 
            btnComunicaciones.BackColor = Color.Transparent;
            btnComunicaciones.BackgroundImage = (Image)resources.GetObject("btnComunicaciones.BackgroundImage");
            btnComunicaciones.FlatAppearance.BorderSize = 2;
            btnComunicaciones.FlatStyle = FlatStyle.Flat;
            btnComunicaciones.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnComunicaciones.ForeColor = Color.White;
            btnComunicaciones.Image = (Image)resources.GetObject("btnComunicaciones.Image");
            btnComunicaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnComunicaciones.Location = new Point(127, 56);
            btnComunicaciones.Margin = new Padding(4);
            btnComunicaciones.Name = "btnComunicaciones";
            btnComunicaciones.Size = new Size(374, 78);
            btnComunicaciones.TabIndex = 0;
            btnComunicaciones.Text = "Comunicaciones";
            btnComunicaciones.UseVisualStyleBackColor = false;
            btnComunicaciones.Click += btnComunicaciones_Click;
            btnComunicaciones.MouseLeave += btnComunicaciones_MouseLeave;
            btnComunicaciones.MouseHover += btnComunicaciones_MouseHover;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.BackColor = Color.Transparent;
            btnCalificaciones.BackgroundImage = (Image)resources.GetObject("btnCalificaciones.BackgroundImage");
            btnCalificaciones.BackgroundImageLayout = ImageLayout.None;
            btnCalificaciones.FlatAppearance.BorderSize = 2;
            btnCalificaciones.FlatStyle = FlatStyle.Flat;
            btnCalificaciones.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalificaciones.ForeColor = Color.White;
            btnCalificaciones.Image = (Image)resources.GetObject("btnCalificaciones.Image");
            btnCalificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalificaciones.Location = new Point(858, 56);
            btnCalificaciones.Margin = new Padding(4);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(374, 78);
            btnCalificaciones.TabIndex = 1;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = false;
            btnCalificaciones.Click += btnCalificaciones_Click;
            btnCalificaciones.MouseLeave += btnCalificaciones_MouseLeave;
            btnCalificaciones.MouseHover += btnCalificaciones_MouseHover;
            // 
            // btnPerfiles
            // 
            btnPerfiles.BackColor = Color.Transparent;
            btnPerfiles.BackgroundImage = (Image)resources.GetObject("btnPerfiles.BackgroundImage");
            btnPerfiles.BackgroundImageLayout = ImageLayout.None;
            btnPerfiles.FlatAppearance.BorderSize = 2;
            btnPerfiles.FlatStyle = FlatStyle.Flat;
            btnPerfiles.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfiles.ForeColor = Color.White;
            btnPerfiles.Image = (Image)resources.GetObject("btnPerfiles.Image");
            btnPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfiles.Location = new Point(552, 56);
            btnPerfiles.Margin = new Padding(4);
            btnPerfiles.Name = "btnPerfiles";
            btnPerfiles.Size = new Size(240, 78);
            btnPerfiles.TabIndex = 2;
            btnPerfiles.Text = "Perfiles";
            btnPerfiles.UseVisualStyleBackColor = false;
            btnPerfiles.Click += btnPerfiles_Click;
            btnPerfiles.MouseLeave += btnPerfiles_MouseLeave;
            btnPerfiles.MouseHover += btnPerfiles_MouseHover;
            BtnImg = (Image)resources.GetObject("btnComunicaciones.BackgroundImage");
            // 
            // pnlElemento
            // 
            pnlElemento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlElemento.AutoSize = true;
            pnlElemento.BackColor = Color.Transparent;
            pnlElemento.BackgroundImage = (Image)resources.GetObject("pnlElemento.BackgroundImage");
            pnlElemento.BackgroundImageLayout = ImageLayout.None;
            pnlElemento.ImeMode = ImeMode.NoControl;
            pnlElemento.Location = new Point(2, 178);
            pnlElemento.Margin = new Padding(2);
            pnlElemento.Name = "pnlElemento";
            pnlElemento.RightToLeft = RightToLeft.No;
            pnlElemento.Size = new Size(1371, 700);
            pnlElemento.TabIndex = 3;
            pnlElemento.Visible = false;
            // 
            // FrmPrincipal
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 880);
            Controls.Add(pnlElemento);
            Controls.Add(btnPerfiles);
            Controls.Add(btnCalificaciones);
            Controls.Add(btnComunicaciones);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuaderno de Comunicaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}