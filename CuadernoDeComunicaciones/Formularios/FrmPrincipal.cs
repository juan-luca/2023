using BibliotecaClases;
using CuadernoDeComunicaciones.Formularios;

namespace CuadernoDeComunicaciones
{
    public partial class FrmPrincipal : Form
    {
        private Usuario usuario;
        private List<Usuario> usuarios;
        private Form FormularioActual = null;
        public FrmPrincipal(Usuario Usuario, List<Usuario> Usuarios)
        {
            InitializeComponent();
            this.usuario = Usuario;
            this.usuarios = Usuarios;
            ConfigurarControlesSegunPerfil();
            IsMdiContainer = true;
        }
        private void ConfigurarControlesSegunPerfil()
        {
            btnComunicaciones.Visible = true;
            btnCalificaciones.Visible = true;
            btnPerfiles.Visible = false;

            if (this.usuario.Perfil == "Director")
            {
                btnPerfiles.Visible = true;

            }
        }


        private void btnComunicaciones_Click(object sender, EventArgs e)
        {
            FrmComunicacion FrmComunicacion = new FrmComunicacion(this.usuario, this.usuarios);

            MostrarFormularioEnPanel(FrmComunicacion);
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            if (this.FormularioActual != null)
            {
                this.FormularioActual.Close();
                this.FormularioActual.Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlElemento.Controls.Add(formulario);
            pnlElemento.Tag = formulario;
            pnlElemento.Visible = true;
            formulario.BringToFront();
            formulario.Show();

            this.FormularioActual = formulario;
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            FrmCalificacion FrmCalificacion = new FrmCalificacion(this.usuario, this.usuarios);

            MostrarFormularioEnPanel(FrmCalificacion);
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            FrmPerfiles FrmPerfil = new FrmPerfiles();

            MostrarFormularioEnPanel(FrmPerfil);
        }

        private void btnComunicaciones_MouseHover(object sender, EventArgs e)
        {
            btnComunicaciones.BackgroundImage = null;

        }

        private void btnComunicaciones_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave("COMU");
        }

        private void btnPerfiles_MouseHover(object sender, EventArgs e)
        {
            btnPerfiles.BackgroundImage = null;
        }

        private void btnCalificaciones_MouseHover(object sender, EventArgs e)
        {
            btnCalificaciones.BackgroundImage = null;
        }

        private void btnCalificaciones_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave("CALI");
        }

        private void btnPerfiles_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave("P");
        }
    }
}