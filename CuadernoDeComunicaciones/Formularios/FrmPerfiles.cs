using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CuadernoDeComunicaciones.Clases;

namespace CuadernoDeComunicaciones.Formularios
{
    public partial class FrmPerfiles : Form
    {
        private List<Usuario> usuarios;

        public FrmPerfiles()
        {
            InitializeComponent();
            HabilitarDeshabilitarBotones();
        }


        private void ActualizarGrilla()
        {
            this.Listar();
        }
        private void Listar()
        {
            this.usuarios = Usuario.ListarTodos();
            this.dgvUsuarios.DataSource = this.usuarios;
        }

        private void Limpiar()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cboPerfil.SelectedIndex = 0;
            txtNombreCompleto.Clear();
            txtNombreUsuario.Enabled = true;
        }

        private void HabilitarDeshabilitarBotones()
        {
            if (!string.IsNullOrEmpty(this.txtNombreUsuario.Text))
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
                Usuario usuarioSeleccionado = usuarios[e.RowIndex];

                txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
                txtNombreUsuario.Enabled = false;
                txtContraseña.Text = usuarioSeleccionado.Contraseña;
                cboPerfil.SelectedItem = (Perfil)Enum.Parse(typeof(Perfil),usuarioSeleccionado.Perfil);
                txtNombreCompleto.Text = usuarioSeleccionado.NombreCompleto;
                
            }
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

                Usuario nuevoUsuario = new Usuario(nombreUsuario, contraseña, perfil, nombreCompleto);

                if (nuevoUsuario.Crear())
                {
                    MessageBox.Show("Usuario creado con éxito");
                }

                this.ActualizarGrilla();


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
                    usuarioSeleccionado.NombreUsuario = txtNombreUsuario.Text; ;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
