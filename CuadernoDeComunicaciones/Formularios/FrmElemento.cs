using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace CuadernoDeComunicaciones
{
    public partial class FrmElemento : Form
    {
        private Usuario usuario;
        private List<Usuario> usuarios;
        private Configuraciones configuraciones;
        public Usuario Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return this.usuarios; }
            set { this.usuarios = value; }
        }
        public ComboBox CboAlumnos
        {
            get { return this.cboAlumno; }
            set { this.cboAlumno.SelectedValue = value; }
        }
        public ComboBox CboDivision
        {
            get { return this.cboDivision; }
            set { this.cboDivision.SelectedValue = value; }
        }
        public Button BtnCrear
        {
            get { return this.btnCrear; }
            set { this.btnCrear = value; }
        }

        public Button BtnModificar
        {
            get { return this.btnModificar; }
            set { this.btnModificar = value; }
        }

        public Button BtnBorrar
        {
            get { return this.btnBorrar; }
            set { this.btnBorrar = value; }
        }

        public Button BtnListar
        {
            get { return this.btnListar; }
            set { this.btnListar = value; }
        }

        public Button BtnLimpiar
        {
            get { return this.btnLimpiar; }
            set { this.btnLimpiar = value; }
        }


        public DateTime Fecha
        {
            get { return this.dtpFecha.Value; }
            set { this.dtpFecha.Value = value; }
        }
        public DataGridView DgvElementos
        {
            get { return this.dgvElementos; }
            set { this.dgvElementos = value; }
        }
        public event EventHandler BtnCrearClick;
        public event EventHandler BtnModificarClick;
        public event EventHandler BtnBorrarClick;
        public event EventHandler BtnListarClick;
        public event EventHandler BtnLimpiarClick;

        public event DataGridViewCellEventHandler dgvElementosCellClick;
        public FrmElemento()
        {
            InitializeComponent();
            this.cboDivision.DataSource =  Enum.GetValues(typeof(Division));

            AplicarConfiguracion();
            ConfigurarControlesSegunPerfilE();
        }
        public FrmElemento(Usuario Usuario, List<Usuario> Usuarios)
        {
            InitializeComponent();
            this.usuario = Usuario;
            this.usuarios = Usuarios;
            this.cboDivision.DataSource = Enum.GetValues(typeof(Division));

            CargarAlumnos();
            AplicarConfiguracion();
            this.ConfigurarControlesSegunPerfilE();

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
        private void CargarAlumnos()
        {
            List<Usuario> usuariosAlumnos = this.usuarios.Where(u => u.Perfil == "Alumno").ToList();
            RelacionesManager relacionesManager = new RelacionesManager();
            if (this.usuario.Perfil=="Alumno")
            {
                // Si el perfil del usuario actual es "Alumno", solo agregar ese usuario a la lista
                Usuario usuarioActual = this.usuarios.FirstOrDefault(u => u.NombreUsuario == this.usuario.NombreUsuario);
                if (usuarioActual != null)
                {
                    usuariosAlumnos.Clear(); // Limpiar la lista actual
                    usuariosAlumnos.Add(usuarioActual);
                }
            }else if(this.usuario.Perfil == "Padres")
            {
                List<Alumno> alumnosRelacionados = relacionesManager.ObtenerAlumnosRelacionados(Usuario.NombreUsuario);
            }
            cboAlumno.DisplayMember = "nombreUsuario";
            cboAlumno.ValueMember = "nombreUsuario";
            cboAlumno.DataSource = usuariosAlumnos;
        }

        protected virtual void ConfigurarControlesSegunPerfil(string Perfil = "")
        {
            if (Perfil == "")
                Perfil = this.usuario.Perfil;


            lblRemitente.Text = Perfil;

            lblRemitenteValue.Text = this.usuario.NombreCompleto;

            switch (Perfil)
            {
                case "Director":
                    this.HabilitarControles(true);
                    break;
                case "Profesor":
                    HabilitarControles(true);
                    break;
                case "Preceptor":
                    HabilitarControles(true);
                    break;
                case "Padres":
                    HabilitarControles(true);
                    break;
                case "Alumno":
                    this.HabilitarControles(false);
                    CboAlumnos.SelectedValue = this.usuario.NombreUsuario;
                    break;
                default:
                    break;
            }
        }

        protected virtual void HabilitarControles(bool habilitar = false, bool modificar = false)
        {
            switch (this.usuario.Perfil)
            {
                case "Director":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = modificar;
                    btnBorrar.Enabled = modificar;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    if (modificar)
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
                    break;
                case "Profesor":
                    habilitar = false;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;

                    break;
                case "Preceptor":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    break;
                case "Padres":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    break;
                case "Alumno":
                    habilitar = false;
                    cboAlumno.Enabled = false;
                    btnCrear.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = false;
                    btnLimpiar.Enabled = false;
                    dtpFecha.Enabled = false;
                    break;
                default:
                    break;
            }







        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            BtnCrearClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BtnModificarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BtnBorrarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BtnListarClick?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void ConfigurarControlesSegunPerfilE(string Perfil = "")
        {
            if (Perfil == "")
                Perfil = this.usuario.Perfil;


            lblRemitente.Text = Perfil;

            lblRemitenteValue.Text = this.usuario.NombreCompleto;

            switch (Perfil)
            {
                case "Director":
                    this.HabilitarControlesE(true);
                    break;
                case "Profesor":
                    HabilitarControlesE(true);
                    break;
                case "Preceptor":
                    HabilitarControlesE(true);
                    break;
                case "Padres":
                    HabilitarControlesE(true);
                    break;
                case "Alumno":
                    this.HabilitarControlesE(false);
                    CboAlumnos.SelectedValue = this.usuario.NombreUsuario;
                    break;
                default:
                    break;
            }
        }
        protected virtual void HabilitarControlesE(bool habilitar = false, bool modificar = false)
        {
            switch (this.usuario.Perfil)
            {
                case "Director":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = modificar;
                    btnBorrar.Enabled = modificar;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    if (modificar)
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
                    break;
                case "Profesor":
                    habilitar = false;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;

                    break;
                case "Preceptor":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    break;
                case "Padres":
                    habilitar = true;
                    cboAlumno.Enabled = true;
                    btnCrear.Enabled = !modificar;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    dtpFecha.Enabled = true;
                    break;
                case "Alumno":
                    habilitar = false;
                    cboAlumno.Enabled = false;
                    btnCrear.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnListar.Enabled = false;
                    btnLimpiar.Enabled = false;
                    dtpFecha.Enabled = false;
                    break;
                default:
                    break;
            }







        }
        private void dgvElementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvElementosCellClick?.Invoke(this, e);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BtnLimpiarClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
