

namespace CuadernoDeComunicaciones
{
    public partial class FrmComunicacion : FrmElemento
    {
        private List<Comunicacion> comunicaciones;
        private string archivoXml = "Comunicaciones.xml";
        public string ComunicacionNroValue
        {
            get { return this.lblComunicacionNroValue.Text; }
        }

        public Categoria CategoriaSeleccionada
        {
            get { return (Categoria)this.cboCategoria.SelectedItem; }
        }

        public string TextoValue
        {
            get { return this.txtTexto.Text; }
        }
        public FrmComunicacion(Usuario Usuario, List<Usuario> Usuarios) : base(Usuario, Usuarios)
        {
            InitializeComponent();
            this.BtnCrearClick += FrmElemento_BtnCrearClick;
            this.BtnModificarClick += FrmElemento_BtnModificarClick;
            this.BtnBorrarClick += FrmElemento_BtnBorrarClick;
            this.BtnListarClick += FrmElemento_BtnListarClick;
            this.comunicaciones=Comunicacion.ListarTodos();
            
            this.DgvElementos.DataSource = this.comunicaciones;
            ConfigurarControlesSegunPerfil(Usuario.Perfil);
        }
        

        private void ConfigurarControlesSegunPerfil(string Perfil)
        {
            switch (Perfil)
            {
                case "Director":
                    
                    break;
                case "Profesor":

                    
                    break;
                case "Preceptor":

                   
                    break;
                case "Padres":

                    
                    break;
                case "Alumno":
                    
                    break;
                default:
                    
                    break;
            }
        }
        private void FrmElemento_BtnCrearClick(object sender, EventArgs e)
        {
            
            Comunicacion nuevaComunicacion = new Comunicacion(this.Usuario.NombreCompleto,this.Alumno, this.ObtenerProximoNumeroComunicacion(), this.CategoriaSeleccionada,this.TextoValue,this.Fecha);

            nuevaComunicacion.Crear();
            this.Listar();

        }
        private void FrmElemento_BtnModificarClick(object sender, EventArgs e)
        {


        }
        private void FrmElemento_BtnBorrarClick(object sender, EventArgs e)
        {



        }
        private void FrmElemento_BtnListarClick(object sender, EventArgs e)
        {
            this.Listar();

        }
        
        private void Listar()
        {
            this.comunicaciones = Comunicacion.ListarTodos();
            this.DgvElementos.DataSource = this.comunicaciones;
        }
        private void Limpiar()
        {
            this.Fecha = DateTime.Now;
            this.lblComunicacionNroValue = null;
            this.cboCategoria.SelectedIndex= 0;
            
        }
        

        private int ObtenerProximoNumeroComunicacion()
        {

            int maxNumero = 0;

            foreach (Comunicacion comunicacion in this.comunicaciones)
            {
                if (comunicacion.ComunicacionNro > maxNumero)
                {
                    maxNumero = comunicacion.ComunicacionNro;
                }
            }

            
            return maxNumero + 1;
        }
    }
}

