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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfig = new Button();
            groupBoxBotonesTest.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(120, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.Window;
            txtContraseña.Location = new Point(121, 144);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(300, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(378, 173);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(43, 51);
            btnLogin.TabIndex = 2;
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
            btnDirector.BackColor = Color.Transparent;
            btnDirector.FlatStyle = FlatStyle.Flat;
            btnDirector.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDirector.ForeColor = Color.White;
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
            btnProfesor.BackColor = Color.Transparent;
            btnProfesor.FlatStyle = FlatStyle.Flat;
            btnProfesor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfesor.ForeColor = Color.White;
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
            btnPreceptor.BackColor = Color.Transparent;
            btnPreceptor.FlatStyle = FlatStyle.Flat;
            btnPreceptor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreceptor.ForeColor = Color.White;
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
            btnPadres.BackColor = Color.Transparent;
            btnPadres.FlatStyle = FlatStyle.Flat;
            btnPadres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPadres.ForeColor = Color.White;
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
            btnAlumno.BackColor = Color.Transparent;
            btnAlumno.FlatStyle = FlatStyle.Flat;
            btnAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlumno.ForeColor = Color.White;
            btnAlumno.Location = new Point(420, 51);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(92, 40);
            btnAlumno.TabIndex = 4;
            btnAlumno.Text = "Alumno";
            btnAlumno.UseVisualStyleBackColor = false;
            btnAlumno.Click += btnAlumno_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Coral;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(84, 88);
            label1.Name = "label1";
            label1.Size = new Size(30, 50);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Coral;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(84, 129);
            label2.Name = "label2";
            label2.Size = new Size(30, 50);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 39);
            label3.Name = "label3";
            label3.Size = new Size(203, 50);
            label3.TabIndex = 6;
            label3.Text = "Iniciar sesion";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.Transparent;
            btnConfig.BackgroundImageLayout = ImageLayout.None;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.Location = new Point(468, 12);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(43, 51);
            btnConfig.TabIndex = 7;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // FrmLogin
            // 
            ClientSize = new Size(523, 322);
            Controls.Add(btnConfig);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(btnLogin);
            Controls.Add(groupBoxBotonesTest);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConfig;
    }
}
