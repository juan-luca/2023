﻿

using BibliotecaClases;

namespace CuadernoDeComunicaciones
{
    public partial class FrmComunicacion : FrmElemento
    {
        private List<Comunicacion> comunicaciones;
        private Configuraciones configuraciones;
        private string archivoXml = "Comunicaciones.xml";
        public string ComunicacionNroValue
        {
            get { return this.lblComunicacionNroValue.Text; }
        }

        public Categoria CategoriaSeleccionada
        {
            get { return (Categoria)this.CboCategoria.SelectedItem; }
        }

        public string TextoValue
        {
            get { return this.txtTexto.Text; }
            set { this.txtTexto.Text = value; }
        }
        public FrmComunicacion(Usuario Usuario, List<Usuario> Usuarios) : base(Usuario, Usuarios)
        {
            InitializeComponent();
            this.CboCategoria.DataSource = Enum.GetValues(typeof(Categoria));

            ConfigurarControlesSegunPerfil(Usuario.Perfil);
            AplicarConfiguracion();
        }


        protected override void ConfigurarControlesSegunPerfil(string Perfil)
        {
            HabilitarControles();

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
                    HabilitarControles();

                    break;
                default:
                    break;
            }

        }
        private void FrmElemento_BtnCrearClick(object sender, EventArgs e)
        {
            try
            {
                Comunicacion nuevaComunicacion = new Comunicacion(this.Usuario.NombreUsuario, this.CboAlumnos.SelectedValue.ToString(), this.ObtenerProximoNumeroComunicacion(), this.CategoriaSeleccionada, this.TextoValue, this.Fecha);

                if (nuevaComunicacion.Crear())
                {
                    MessageBox.Show("Comunicado creado con exito");

                    ActualizarGrilla();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el comunicado: " + ex.Message);
            }

        }
        private void FrmElemento_BtnModificarClick(object sender, EventArgs e)
        {
            try
            {

                int ComunicacionNro = -1;
                int.TryParse(lblComunicacionNroValue.Text, out ComunicacionNro);

                Comunicacion nuevaComunicacion = new Comunicacion(this.Usuario.NombreCompleto, this.CboAlumnos.SelectedValue.ToString(), ComunicacionNro, this.CategoriaSeleccionada, this.TextoValue, this.Fecha);

                if (nuevaComunicacion.Modificar())
                {
                    MessageBox.Show("Comunicado modificado con exito");

                    ActualizarGrilla();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el comunicado. " + ex.Message);
            }

        }
        private void FrmElemento_BtnBorrarClick(object sender, EventArgs e)
        {
            try
            {

                int ComunicacionNro = -1;
                int.TryParse(lblComunicacionNroValue.Text, out ComunicacionNro);

                Comunicacion nuevaComunicacion = new Comunicacion(this.Usuario.NombreCompleto, this.CboAlumnos.SelectedValue.ToString(), ComunicacionNro, this.CategoriaSeleccionada, this.TextoValue, this.Fecha);

                if (nuevaComunicacion.Borrar())
                {
                    MessageBox.Show("Comunicado eliminado con exito");

                    ActualizarGrilla();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el comunicado. " + ex.Message);
            }


        }
        private void ActualizarGrilla()
        {
            this.Listar();
            this.Limpiar();
        }

        private void FrmElemento_BtnListarClick(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }
        private void FrmElemento_BtnLimpiarClick(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }
        private void FrmElemento_dgvElementosCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow fila = this.DgvElementos.Rows[e.RowIndex];
                
                string comunicacionNro = fila.Cells[0].Value.ToString();
                Categoria categoria = (Categoria)Enum.Parse(typeof(Categoria), fila.Cells[1].Value.ToString());
                string texto = fila.Cells["Texto"].Value.ToString();
                DateTime Fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value.ToString());
                this.lblComunicacionNroValue.Text = comunicacionNro;
                this.CboCategoria.SelectedItem = categoria;
                string alumno = fila.Cells["Alumno"].Value.ToString();
                this.CboAlumnos.SelectedValue = alumno;
                this.txtTexto.Text = texto;
                this.Fecha = Fecha;
                Usuarios = Usuario.ListarTodos();
                // Buscar el usuario en la lista por nombre de usuario
                Usuario usuario = Usuarios.Find(u => u.NombreUsuario == alumno);

                // Verificar si se encontró el usuario y tiene un valor de división
                if (usuario != null && int.TryParse(usuario.Division, out int valorDivision))
                {
                    this.CboDivision.SelectedIndex = valorDivision;
                }
                else
                {
                    this.CboDivision.SelectedIndex = 0;
                }


            }

        }

        private void Listar()
        {
            this.comunicaciones = Comunicacion.ListarTodos();
            RelacionesManager relacionesManager = new RelacionesManager();

            


           
           
            if (this.CboDivision.SelectedIndex != null)
            {
                if (this.CboDivision.SelectedIndex != 0)
                {
                    // Obtener usuarios en la división
                    List<Usuario> usuariosEnDivision = Usuarios.Where(u => u.Division == this.CboDivision.SelectedIndex.ToString()).ToList();

                    // Obtener comunicaciones relacionadas con la división
                    comunicaciones = Comunicacion.ListarComunicacionesPorDivision(usuariosEnDivision);
                }
            }


            if (Usuario.Perfil == "Padres")
            {
                List<Alumno> alumnosRelacionados = relacionesManager.ObtenerAlumnosRelacionados(Usuario.NombreUsuario);
                comunicaciones = Comunicacion.ListarComunicacionesDeAlumno(alumnosRelacionados);
            }
            else if (Usuario.Perfil == "Alumno")
            {
                comunicaciones = Comunicacion.ListarComunicacionesDeAlumno(Usuario.NombreUsuario);
            }


            this.DgvElementos.DataSource = this.comunicaciones;
        }
      
        private void Limpiar()
        {
            this.Fecha = DateTime.Now;
            this.lblComunicacionNroValue.Text = "";
            this.CboCategoria.SelectedIndex = 0;
            this.CboAlumnos.SelectedIndex = 0;
            this.TextoValue = "";

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

        private void lblComunicacionNroValue_TextChanged(object sender, EventArgs e)
        {
            HabilitarControles();
        }
        public void AplicarConfiguracion()
        {
            configuraciones = Configuraciones.CargarConfiguraciones();
            if (configuraciones.ModoOscuro)
            {
                // Aplicar cambios para el modo oscuro
                this.BackColor = Color.FromArgb(30, 30, 30);
                DgvElementos.BackgroundColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                // Restaurar a los valores por defecto o modo claro
                this.BackColor = Color.LightGray;
                DgvElementos.BackgroundColor = Color.LightGray;
            }
            foreach (Control control in Controls)
            {
                AplicarConfiguracionRecursiva(control, configuraciones.ModoOscuro);
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
        private void AplicarConfiguracionRecursiva(Control control, bool modoOscuro)
        {
            foreach (Control subControl in control.Controls)
            {
                subControl.BackColor = modoOscuro ? Color.FromArgb(30, 30, 30) : Color.LightGray;
                subControl.ForeColor = modoOscuro ? Color.White : Color.Black;

                // Aplicar configuración a controles anidados
                AplicarConfiguracionRecursiva(subControl, modoOscuro);
            }
        }
        protected override void HabilitarControles(bool habilitar = false, bool modificar = false)
        {


            switch (base.Usuario.Perfil)
            {
                case "Director":
                    habilitar = true;
                    break;
                case "Profesor":
                    habilitar = true;
                    break;
                case "Preceptor":
                    habilitar = true;
                    break;
                case "Padres":
                    habilitar = true;
                    break;
                case "Alumno":
                    habilitar = false;
                    txtTexto.Enabled = false;
                    CboCategoria.Enabled = false;
                    break;
                default:
                    break;
            }
            base.HabilitarControles(habilitar, !string.IsNullOrEmpty(this.lblComunicacionNroValue.Text));


        }

    }
}

