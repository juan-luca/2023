namespace CuadernoDeComunicaciones
{
    public partial class FrmPrincipal : Form
    {
        private Usuario usuario;
        private List<Usuario> usuarios;
        public FrmPrincipal(Usuario Usuario, List<Usuario> Usuarios)
        {
            InitializeComponent();
            this.usuario = Usuario;
            this.usuarios = Usuarios;
            ConfigurarControlesSegunPerfil();
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
            FrmComunicacion.Show();
        }

        // Evento para abrir FrmCalificacion
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            //  FrmCalificacion FrmCalificacion = new FrmCalificacion(perfilUsuario);
            //FrmCalificacion.Show();
        }

        // Evento para abrir FrmPerfil
        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            //FrmPerfil FrmPerfil = new FrmPerfil(perfilUsuario);
            //FrmPerfil.Show();
        }
    }
}