﻿using BibliotecaClases;
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
        private Configuraciones configuraciones;
        private bool Instanciado = false;

        private IErrorLogger<CustomError> errorLogger = new ErrorLogger<CustomError>();
        public Materia MateriaSeleccionada
        {
            get { return (Materia)this.CboMateria.SelectedItem; }
        }

        public FrmCalificacion(Usuario Usuario, List<Usuario> Usuarios) : base(Usuario, Usuarios)
        {
            InitializeComponent();
            this.CboMateria.DataSource = Enum.GetValues(typeof(Materia));
            this.Instanciado = true;
            ConfigurarControlesSegunPerfil(Usuario.Perfil);
            AplicarConfiguracion();
            Listar();
        }
        protected override void ConfigurarControlesSegunPerfil(string Perfil)
        {
            try
            {
                
                if(Instanciado)
                {
                    
                    this.HabilitarControles();
                    
                    switch (Perfil)
                    {
                        case "Director":
                            break;
                        case "Profesor":
                            break;
                        case "Preceptor":
                            BtnCrear.Enabled = false;
                            BtnModificar.Enabled = false;
                            BtnBorrar.Enabled = false;
                            break;
                        case "Padres":
                            BtnCrear.Enabled = false;
                            BtnModificar.Enabled = false;
                            BtnBorrar.Enabled = false;
                            break;
                        case "Alumno":
                            HabilitarControles();
                            break;
                        default:
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                CustomError error = new CustomError($"Error al crear calificación: {ex.Message}");

                if (errorLogger != null)
                {
                    errorLogger.LogError(error);
                }
                MessageBox.Show("Error .", ex.Message);

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
        private void CargarAlumnosPorDivision(List<Usuario> usuarios)
        {
            // Crear un objeto BindingSource y asignar la lista de usuarios
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = usuarios;

            // Asignar el BindingSource como fuente de datos del ComboBox
            CboAlumnos.DataSource = bindingSource;

            // Establecer las propiedades DisplayMember y ValueMember del ComboBox
            CboAlumnos.DisplayMember = "NombreCompleto"; // Cambia esto según las propiedades del objeto Usuario
            CboAlumnos.ValueMember = "NombreUsuario"; // Cambia esto según las propiedades del objeto Usuario

            // Seleccionar el primer elemento
            if (CboAlumnos.Items.Count > 0)
            {
                CboAlumnos.SelectedIndex = 0;
            }
        }
        private void Listar()
        {
            this.calificaciones = Calificacion.ListarTodos();
            RelacionesManager relacionesManager = new RelacionesManager();

            if (this.CboDivision.SelectedIndex != null)
            {
                if (this.CboDivision.SelectedIndex != 0)
                {
                    // Obtener usuarios en la división
                    List<Usuario> usuariosEnDivision = Usuarios.Where(u => u.Division == this.CboDivision.SelectedIndex.ToString()).ToList();

                    // Obtener comunicaciones relacionadas con la división
                    calificaciones = Calificacion.ListarCalificacionesPorDivision(usuariosEnDivision);
                    if (this.Usuario.Perfil != "Alumno")
                    { 
                        if(this.Usuario.Perfil != "Padres")
                        {
                            CargarAlumnosPorDivision(usuariosEnDivision);
                        }
                        
                    }else
                    {

                    }
                    // Cargar los alumnos de la división en CboAlumnos
                   
                }
            }

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
            this.CboDivision.SelectedIndex = 0;
        }

        protected override void HabilitarControles(bool habilitar = false, bool modificar = false)
        {
            bool habilitarFiltro = false;
            try
            {
                
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

                        CboDivision.Enabled = false;

                        if (base.Usuario != null && int.TryParse(base.Usuario.Division, out int valorDivision))
                        {
                            this.CboDivision.SelectedIndex = valorDivision;
                            
                        }
                        else
                        {
                            this.CboDivision.SelectedIndex = 0;
                        }
                        break;
                    default:
                        break;
                }

                txtObservaciones.Enabled = habilitar;
                txtConcepto.Enabled = habilitar;
                nuNota.Enabled = habilitar;
                CboMateria.Enabled = habilitar;

                

                CboAlumnos.Enabled = habilitarFiltro;
            }
            catch (Exception ex)
            {
                CustomError error = new CustomError($"Error al crear calificación: {ex.Message}");

                if (errorLogger != null)
                {
                    errorLogger.LogError(error);
                }
                throw new Exception("Error al modificar la comunicación en la base de datos.", ex);

            }

            

        }
        private void ActualizarGrilla()
        {
            this.Limpiar();
            this.Listar();
           
        }

    }
}
