﻿

using CuadernoDeComunicaciones.Clases;

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
            this.BtnCrearClick += FrmElemento_BtnCrearClick;
            this.BtnModificarClick += FrmElemento_BtnModificarClick;
            this.BtnBorrarClick += FrmElemento_BtnBorrarClick;
            this.BtnListarClick += FrmElemento_BtnListarClick;
            this.BtnLimpiarClick += FrmElemento_BtnLimpiarClick;
            this.dgvElementosCellClick += FrmElemento_dgvElementosCellClick;
            this.comunicaciones = Comunicacion.ListarTodos();

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
            try
            {
                Comunicacion nuevaComunicacion = new Comunicacion(this.Usuario.NombreCompleto, this.CboAlumnos.SelectedValue.ToString(), this.ObtenerProximoNumeroComunicacion(), this.CategoriaSeleccionada, this.TextoValue, this.Fecha);

                if (nuevaComunicacion.Crear())
                {
                    MessageBox.Show("Comunicado creado con exito");

                    this.Listar();
                    this.Limpiar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el comunicado: " + ex.Message);
            }

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
        private void FrmElemento_BtnLimpiarClick(object sender, EventArgs e)
        {
            this.Limpiar();

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
                this.txtTexto.Text = texto;
                this.Fecha = Fecha;
            }

        }


        private void Listar()
        {
            this.comunicaciones = Comunicacion.ListarTodos();
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
            if (!string.IsNullOrEmpty(this.lblComunicacionNroValue.Text))
            {
                this.BtnCrear.Enabled = false;
                this.BtnModificar.Enabled = true;
                this.BtnBorrar.Enabled = true;
            }
            else
            {
                this.BtnCrear.Enabled = true;
                this.BtnModificar.Enabled = false;
                this.BtnBorrar.Enabled = false;
            }
        }
    }
}

