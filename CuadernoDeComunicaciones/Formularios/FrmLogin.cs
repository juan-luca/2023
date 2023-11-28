using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using BibliotecaClases;
using CuadernoDeComunicaciones.Formularios;

namespace CuadernoDeComunicaciones
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        private Configuraciones configuraciones;
        public FrmLogin()
        {
            InitializeComponent();
            CargarUsuariosDesdeXML();


            AplicarConfiguracion();
        }
        public void AplicarConfiguracion()
        {
            configuraciones = Configuraciones.CargarConfiguraciones();
            if (configuraciones.ModoOscuro)
            {
                // Aplicar cambios para el modo oscuro
                this.BackColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                // Restaurar a los valores por defecto o modo claro
                this.BackColor = Color.LightGray;
            }
            foreach (Control control in Controls)
            {
                if (configuraciones.ModoOscuro)
                {
                    // Aplicar cambios para el modo oscuro
                    control.BackColor = Color.FromArgb(30, 30, 30);
                }
                else
                {
                    // Restaurar a los valores por defecto o modo claro
                    control.BackColor = Color.LightGray;
                }
            }
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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario FrmConfiguraciones
            FrmConfiguracion frmConfiguraciones = new FrmConfiguracion();

            // Muestra el formulario FrmConfiguraciones de manera modal (bloquea el FrmLogin)
            DialogResult result = frmConfiguraciones.ShowDialog();

            // Verifica si el usuario guardó las configuraciones antes de cerrar el formulario
            if (result == DialogResult.Cancel)
            {
                AplicarConfiguracion();
            }
        }
    }
}
