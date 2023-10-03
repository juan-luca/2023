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
            txtUsuario.Location = new Point(116, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(300, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(116, 104);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(300, 23);
            txtContraseña.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(116, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBoxBotonesTest
            // 
            groupBoxBotonesTest.Controls.Add(btnDirector);
            groupBoxBotonesTest.Controls.Add(btnProfesor);
            groupBoxBotonesTest.Controls.Add(btnPreceptor);
            groupBoxBotonesTest.Controls.Add(btnPadres);
            groupBoxBotonesTest.Controls.Add(btnAlumno);
            groupBoxBotonesTest.Location = new Point(-1, 207);
            groupBoxBotonesTest.Name = "groupBoxBotonesTest";
            groupBoxBotonesTest.Size = new Size(523, 64);
            groupBoxBotonesTest.TabIndex = 3;
            groupBoxBotonesTest.TabStop = false;
            groupBoxBotonesTest.Text = "Botones de TEST";
            // 
            // btnDirector
            // 
            btnDirector.Location = new Point(59, 20);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(74, 40);
            btnDirector.TabIndex = 0;
            btnDirector.Text = "Director";
            btnDirector.Click += btnDirector_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.Location = new Point(139, 20);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(74, 40);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "Profesor";
            btnProfesor.Click += btnProfesor_Click;
            // 
            // btnPreceptor
            // 
            btnPreceptor.Location = new Point(217, 20);
            btnPreceptor.Name = "btnPreceptor";
            btnPreceptor.Size = new Size(79, 40);
            btnPreceptor.TabIndex = 2;
            btnPreceptor.Text = "Preceptor";
            btnPreceptor.Click += btnPreceptor_Click;
            // 
            // btnPadres
            // 
            btnPadres.Location = new Point(300, 20);
            btnPadres.Name = "btnPadres";
            btnPadres.Size = new Size(74, 40);
            btnPadres.TabIndex = 3;
            btnPadres.Text = "Padres";
            btnPadres.Click += btnPadres_Click;
            // 
            // btnAlumno
            // 
            btnAlumno.Location = new Point(378, 20);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(74, 40);
            btnAlumno.TabIndex = 4;
            btnAlumno.Text = "Alumno";
            btnAlumno.Click += btnAlumno_Click;
            // 
            // FrmLogin
            // 
            ClientSize = new Size(523, 283);
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
