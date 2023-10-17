using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CuadernoDeComunicaciones.Clases;

namespace CuadernoDeComunicaciones.Formularios
{
    public partial class FrmPerfiles : Form
    {
        private List<Usuario> usuarios;
        private List<Usuario> padres;
        private List<Usuario> madres;
        private RelacionesManager relacionesManager;
        private bool FilaSeleccionada = false;
        public FrmPerfiles()
        {
            InitializeComponent();
            relacionesManager = new RelacionesManager();
            HabilitarDeshabilitarBotones();
        }


        private void ActualizarGrilla()
        {
            this.Limpiar();
            this.Listar();
        }
        private void Listar()
        {
            this.usuarios = Usuario.ListarTodos();
            this.dgvUsuarios.DataSource = this.usuarios;
            this.padres = usuarios.Where(u => u.Perfil == "Padres").ToList();
            this.madres = usuarios.Where(u => u.Perfil == "Padres").ToList();
            padres.Insert(0, new Usuario { NombreUsuario = "Sin Seleccionar" });
            madres.Insert(0, new Usuario { NombreUsuario = "Sin Seleccionar" });

            
            cboPadre.DataSource = padres;
            cboMadre.DataSource = madres;


        }

        private void Limpiar()
        {
            this.LimpiarParcial();
            txtNombreUsuario.Enabled = true;
            dgvUsuarios.ClearSelection();
            
            this.FilaSeleccionada = false;
        }
        private void LimpiarParcial()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cboPerfil.SelectedIndex = 0;
            txtNombreCompleto.Clear();
            cboPadre.SelectedIndex = 0;
            cboMadre.SelectedIndex = 0;
        }

        private void HabilitarDeshabilitarBotones()
        {
            if (!string.IsNullOrEmpty(this.txtNombreUsuario.Text) && this.FilaSeleccionada)
            {
                this.btnCrear.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnCrear.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }
        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.LimpiarParcial();

                Usuario usuarioSeleccionado = usuarios[e.RowIndex];
                RelacionesManager relacion = new RelacionesManager();

                txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
                txtNombreUsuario.Enabled = false;
                txtContraseña.Text = usuarioSeleccionado.Contraseña;
                cboPerfil.SelectedItem = (Perfil)Enum.Parse(typeof(Perfil), usuarioSeleccionado.Perfil);
                txtNombreCompleto.Text = usuarioSeleccionado.NombreCompleto;
                if (usuarioSeleccionado.Perfil == "Alumno")
                {
                    Alumno alumno=relacion.ObtenerAlumnoPorNombreUsuario(usuarioSeleccionado.NombreUsuario);
                    if(alumno!=null)
                    {
                        cboMadre.SelectedValue = alumno.Madre;
                        cboPadre.SelectedValue = alumno.Padre;
                    }
                    
                }

                this.FilaSeleccionada = true;
            }
            else
            {
                this.FilaSeleccionada = false;
            }
            HabilitarDeshabilitarBotones();
        }
       

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarDeshabilitarBotones();
        }
       
        
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña.Text;
                string perfil = cboPerfil.SelectedItem.ToString();
                string nombreCompleto = txtNombreCompleto.Text;
                
                if(perfil=="Alumno")
                {
                    if (cboPadre.SelectedIndex == 0 || cboMadre.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar un padre y una madre válidos.");
                        return;
                    }
                    string padre = cboPadre.SelectedValue.ToString();
                    string madre = cboMadre.SelectedValue.ToString();

                    Alumno nuevoAlumno = new Alumno(nombreUsuario, contraseña, perfil, nombreCompleto, padre, madre);
                    relacionesManager.CrearRelacion(nuevoAlumno);

                   

                }
                    Usuario nuevoUsuario = new Usuario(nombreUsuario, contraseña, perfil, nombreCompleto);

                    if (!nuevoUsuario.Crear())
                    {
                        throw new Exception("Error al crear el usuario");

                        
                    }

                this.ActualizarGrilla();
                MessageBox.Show("Usuario creado con éxito");




                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgvUsuarios.SelectedCells[0].RowIndex;

                if (selectedIndex >= 0)
                {
                    string nombreUsuario = txtNombreUsuario.Text;
                    string contraseña = txtContraseña.Text;
                    string perfil = cboPerfil.SelectedItem.ToString();
                    string nombreCompleto = txtNombreCompleto.Text;
                    if(perfil=="Alumno")
                    {
                        if (cboPadre.SelectedIndex == 0 || cboMadre.SelectedIndex == 0)
                        {
                            MessageBox.Show("Debe seleccionar un padre y una madre válidos.");
                            return;
                        }
                        string padre = cboPadre.SelectedValue.ToString();
                        string madre = cboMadre.SelectedValue.ToString();

                        Alumno alumnoModificado = new Alumno(nombreUsuario, contraseña, perfil, nombreCompleto, padre, madre);

                        relacionesManager.CrearRelacion(alumnoModificado);

                    }

                    Usuario usuarioSeleccionado = usuarios[selectedIndex];
                    usuarioSeleccionado.NombreUsuario = nombreUsuario;
                    usuarioSeleccionado.Contraseña = contraseña;
                    usuarioSeleccionado.Perfil = perfil;
                    usuarioSeleccionado.NombreCompleto = nombreCompleto;
                    if (usuarioSeleccionado.Modificar())
                    {
                        MessageBox.Show("Usuario modificado con éxito");
                    }

                    this.ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgvUsuarios.SelectedCells[0].RowIndex;

                if (selectedIndex >= 0)
                {
                    Usuario usuarioSeleccionado = usuarios[selectedIndex];
                    usuarioSeleccionado.NombreUsuario = txtNombreUsuario.Text;

                    relacionesManager.BorrarRelacion(usuarioSeleccionado.NombreUsuario);

                    if (usuarioSeleccionado.Borrar())
                    {
                        MessageBox.Show("Usuario eliminado con éxito");
                    }

                    this.ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPerfil.SelectedItem.ToString() == "Alumno")
            {
                cboPadre.Visible = true;
                cboMadre.Visible = true;
                lblPadre.Visible = true;
                lblMadre.Visible = true;
            }
            else
            {
                cboPadre.Visible = false;
                cboMadre.Visible = false;
                lblPadre.Visible = false;
                lblMadre.Visible = false;
            }
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
