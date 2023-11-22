using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using BibliotecaClases;
namespace CuadernoDeComunicaciones
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            CargarUsuariosDesdeXML();
        }

        private void CargarUsuariosDesdeXML()
        {

            this.usuarios = Usuario.ListarTodos();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;


            Usuario usuarioEncontrado = null;

            foreach (Usuario u in this.usuarios)
            {
                if (u.NombreUsuario == usuario && u.Contraseña == contraseña)
                {
                    usuarioEncontrado = u;
                    break;
                }
            }
            if (usuarioEncontrado != null)
            {

                FrmPrincipal frmPrincipal = new FrmPrincipal(usuarioEncontrado, this.usuarios);
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Director";
            txtContraseña.Text = "contraseña_director";
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Profesor";
            txtContraseña.Text = "contraseña_profesor";
        }

        private void btnPreceptor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Preceptor";
            txtContraseña.Text = "contraseña_preceptor";
        }

        private void btnPadres_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Padres";
            txtContraseña.Text = "contraseña_padres";
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {

            txtUsuario.Text = "Alumno";
            txtContraseña.Text = "contraseña_alumno";
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
