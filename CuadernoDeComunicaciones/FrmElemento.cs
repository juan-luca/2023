using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernoDeComunicaciones
{
    public partial class FrmElemento : Form
    {
        private Usuario usuario;
        private List<Usuario> usuarios;
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
        public string Alumno
        {
            get { return this.cboAlumno.SelectedValue.ToString(); }
            set { this.cboAlumno.SelectedValue = value; }
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
        public FrmElemento(Usuario Usuario, List<Usuario> Usuarios)
        {
            InitializeComponent();
            this.usuario = Usuario;
            this.usuarios = Usuarios;

            CargarAlumnos();
            ConfigurarControlesSegunPerfil();
        }
        private void CargarAlumnos()
        {
            List<Usuario> usuariosAlumnos = this.usuarios.Where(u => u.Perfil == "Alumno").ToList();


            cboAlumno.DisplayMember = "nombreCompleto";
            cboAlumno.ValueMember = "nombreCompleto";
            cboAlumno.DataSource = usuariosAlumnos;
        }

        private void ConfigurarControlesSegunPerfil()
        {
            lblRemitente.Text = this.usuario.Perfil;
            lblRemitenteValue.Text = this.usuario.NombreCompleto;
            switch (this.usuario.Perfil)
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
    }
}
