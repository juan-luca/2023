using System.Drawing;
namespace CuadernoDeComunicaciones
{
    partial class FrmLogin : Form
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            groupBoxBotonesTest = new GroupBox();
            btnDirector = new Button();
            btnProfesor = new Button();
            btnPreceptor = new Button();
            btnPadres = new Button();
            btnAlumno = new Button();
            groupBoxBotonesTest.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(116, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.Location = new Point(116, 104);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(300, 27);
            txtContraseña.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lavender;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(116, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 51);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar sesion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBoxBotonesTest
            // 
            groupBoxBotonesTest.BackColor = Color.Transparent;
            groupBoxBotonesTest.Controls.Add(btnDirector);
            groupBoxBotonesTest.Controls.Add(btnProfesor);
            groupBoxBotonesTest.Controls.Add(btnPreceptor);
            groupBoxBotonesTest.Controls.Add(btnPadres);
            groupBoxBotonesTest.Controls.Add(btnAlumno);
            groupBoxBotonesTest.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxBotonesTest.ForeColor = Color.White;
            groupBoxBotonesTest.Location = new Point(1, 218);
            groupBoxBotonesTest.Name = "groupBoxBotonesTest";
            groupBoxBotonesTest.Size = new Size(523, 103);
            groupBoxBotonesTest.TabIndex = 3;
            groupBoxBotonesTest.TabStop = false;
            groupBoxBotonesTest.Text = "Botones de TEST";
            // 
            // btnDirector
            // 
            btnDirector.BackColor = Color.LavenderBlush;
            btnDirector.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDirector.ForeColor = Color.Black;
            btnDirector.Location = new Point(12, 51);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(106, 40);
            btnDirector.TabIndex = 0;
            btnDirector.Text = "Director";
            btnDirector.UseVisualStyleBackColor = false;
            btnDirector.Click += btnDirector_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = Color.LavenderBlush;
            btnProfesor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfesor.ForeColor = Color.Black;
            btnProfesor.Location = new Point(125, 51);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(104, 40);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "Profesor";
            btnProfesor.UseVisualStyleBackColor = false;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // btnPreceptor
            // 
            btnPreceptor.BackColor = Color.LavenderBlush;
            btnPreceptor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreceptor.ForeColor = Color.Black;
            btnPreceptor.Location = new Point(232, 51);
            btnPreceptor.Name = "btnPreceptor";
            btnPreceptor.Size = new Size(97, 40);
            btnPreceptor.TabIndex = 2;
            btnPreceptor.Text = "Preceptor";
            btnPreceptor.UseVisualStyleBackColor = false;
            btnPreceptor.Click += btnPreceptor_Click;
            // 
            // btnPadres
            // 
            btnPadres.BackColor = Color.LavenderBlush;
            btnPadres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPadres.ForeColor = Color.Black;
            btnPadres.Location = new Point(333, 51);
            btnPadres.Name = "btnPadres";
            btnPadres.Size = new Size(84, 40);
            btnPadres.TabIndex = 3;
            btnPadres.Text = "Padres";
            btnPadres.UseVisualStyleBackColor = false;
            btnPadres.Click += btnPadres_Click;
            // 
            // btnAlumno
            // 
            btnAlumno.BackColor = Color.LavenderBlush;
            btnAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlumno.ForeColor = Color.Black;
            btnAlumno.Location = new Point(420, 51);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(92, 40);
            btnAlumno.TabIndex = 4;
            btnAlumno.Text = "Alumno";
            btnAlumno.UseVisualStyleBackColor = false;
            btnAlumno.Click += btnAlumno_Click;
            // 
            // FrmLogin
            // 
            BackColor = Color.Firebrick;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(523, 322);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(btnLogin);
            Controls.Add(groupBoxBotonesTest);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            groupBoxBotonesTest.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private GroupBox groupBoxBotonesTest;
        private Button btnDirector;
        private Button btnProfesor;
        private Button btnPreceptor;
        private Button btnPadres;
        private Button btnAlumno;
    }
}
