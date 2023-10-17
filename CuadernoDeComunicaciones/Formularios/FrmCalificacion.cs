using CuadernoDeComunicaciones.Clases;
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
    public partial class FrmCalificacion : FrmElemento
    {
        private List<Calificacion> calificaciones;
        private string archivoXml = "Calificaciones.xml";
        public Materia MateriaSeleccionada
        {
            get { return (Materia)this.CboMateria.SelectedItem; }
        }

        public FrmCalificacion(Usuario Usuario, List<Usuario> Usuarios) : base(Usuario, Usuarios)
        {
            InitializeComponent();

            ConfigurarControlesSegunPerfil(Usuario.Perfil);
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


        private int ObtenerProximoNumeroCalificacion()
        {

            int maxNumero = 0;
            if (this.calificaciones != null)
            {
                foreach (Calificacion Calificacion in this.calificaciones)
                {
                    if (Calificacion.CalificacionNro > maxNumero)
                    {
                        maxNumero = Calificacion.CalificacionNro;
                    }
                }
            }



            return maxNumero + 1;
        }

        private void FrmElemento_BtnCrearClick(object sender, EventArgs e)
        {
            try
            {
                double Nota = -1;
                double.TryParse(this.nuNota.Text, out Nota);


                Calificacion nuevaCalificacion = new Calificacion(this.Usuario.NombreUsuario, this.CboAlumnos.SelectedValue.ToString(), Nota, this.MateriaSeleccionada, this.ObtenerProximoNumeroCalificacion(), this.txtConcepto.Text, this.txtObservaciones.Text, this.Fecha);

                if (nuevaCalificacion.Crear())
                {
                    MessageBox.Show("Calificación creada con éxito");
                    ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la calificación: " + ex.Message);
            }
        }
        private void FrmElemento_BtnModificarClick(object sender, EventArgs e)
        {
            try
            {
                int CalificacionNro = -1;
                int.TryParse(this.lblCalificacionNroValue.Text, out CalificacionNro);

                double nuNota = 0;
                double.TryParse(this.nuNota.Text, out nuNota);

                Calificacion calificacionExistente = this.calificaciones.FirstOrDefault(c => c.CalificacionNro == CalificacionNro);

                if (calificacionExistente != null)
                {
                    calificacionExistente.Alumno = this.CboAlumnos.SelectedValue.ToString();
                    calificacionExistente.Materia = this.MateriaSeleccionada;
                    calificacionExistente.Nota = nuNota;
                    calificacionExistente.Observaciones = this.txtObservaciones.Text;
                    calificacionExistente.Concepto = this.txtConcepto.Text;
                    calificacionExistente.Fecha = this.Fecha;

                    if (calificacionExistente.Modificar())
                    {
                        MessageBox.Show("Calificación modificada con éxito");

                        this.ActualizarGrilla();
                        this.Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("La calificación no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la calificación: " + ex.Message);
            }
        }

        private void FrmElemento_BtnBorrarClick(object sender, EventArgs e)
        {
            try
            {
                int CalificacionNro = -1;
                int.TryParse(this.lblCalificacionNroValue.Text, out CalificacionNro);

                Calificacion calificacionExistente = this.calificaciones.FirstOrDefault(c => c.CalificacionNro == CalificacionNro);

                if (calificacionExistente != null)
                {
                    if (calificacionExistente.Borrar())
                    {
                        MessageBox.Show("Calificación eliminada con éxito");

                        this.ActualizarGrilla();
                        this.Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("La calificación no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la calificación: " + ex.Message);
            }
        }

        private void FrmElemento_BtnListarClick(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void FrmElemento_BtnLimpiarClick(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }
        private void lblCalificacionNroValue_TextChanged(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        private void FrmElemento_dgvElementosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow fila = this.DgvElementos.Rows[e.RowIndex];

                int calificacionNro = Convert.ToInt32(fila.Cells[0].Value);
                Materia materia = (Materia)Enum.Parse(typeof(Materia), fila.Cells[1].Value.ToString());
                double nota = Convert.ToDouble(fila.Cells["Nota"].Value);
                string observaciones = fila.Cells["Observaciones"].Value.ToString();
                string concepto = fila.Cells["Concepto"].Value.ToString();
                DateTime Fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value.ToString());
                string alumno = fila.Cells["Alumno"].Value.ToString();
                this.CboAlumnos.SelectedValue = alumno;
                this.lblCalificacionNroValue.Text = calificacionNro.ToString();
                this.CboMateria.SelectedItem = materia;
                this.nuNota.Text = nota.ToString();
                this.txtObservaciones.Text = observaciones;
                this.txtConcepto.Text = concepto;
                this.Fecha = Fecha;
            }
        }

        private void Listar()
        {
            this.calificaciones = Calificacion.ListarTodos();
            RelacionesManager relacionesManager = new RelacionesManager();
            if (Usuario.Perfil == "Padres")
            {
               List<Alumno> alumnosRelacionados = relacionesManager.ObtenerAlumnosRelacionados(Usuario.NombreUsuario);

                calificaciones = Calificacion.ListarCalificacionesDeAlumno(alumnosRelacionados);
            }
            else if (Usuario.Perfil == "Alumno")
            {
                
                calificaciones = Calificacion.ListarCalificacionesDeAlumno(Usuario.NombreUsuario);
            }

            this.DgvElementos.DataSource = this.calificaciones;
        }
       

        private void Limpiar()
        {
            this.Fecha = DateTime.Now;
            this.lblCalificacionNroValue.Text = "";
            this.CboMateria.SelectedIndex = 0;
            this.nuNota.Text = "";
            this.txtObservaciones.Text = "";
            this.txtConcepto.Text = "";
        }
       
        protected override void HabilitarControles(bool habilitar = false, bool modificar = false)
        {
            bool habilitarFiltro = false;


            switch (base.Usuario.Perfil)
            {
                case "Director":
                    habilitar = true;
                    modificar = true;
                    habilitarFiltro = true;
                    break;
                case "Profesor":
                    habilitar = true;
                    habilitarFiltro = true;
                    break;
                case "Preceptor":
                    habilitar = true;
                    habilitarFiltro = true;
                    break;
                case "Padres":
                    habilitar = false;
                    habilitarFiltro = false;
                    break;
                case "Alumno":
                    habilitar = false;
                    habilitarFiltro = false;
                    break;
                default:
                    break;
            }

            txtObservaciones.Enabled = habilitar;
            txtConcepto.Enabled = habilitar;
            nuNota.Enabled = habilitar;
            CboMateria.Enabled = habilitar;

            base.HabilitarControles(habilitar, !string.IsNullOrEmpty(this.lblCalificacionNroValue.Text));

            CboAlumnos.Enabled = habilitarFiltro;

        }
        private void ActualizarGrilla()
        {
            this.Listar();
            this.Limpiar();
        }

    }
}
