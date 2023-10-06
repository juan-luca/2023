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

            this.usuarios = Usuario.ListarTodos();

            this.dgvUsuarios.DataSource = this.usuarios;


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
        }

        private void Limpiar()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cboPerfil.SelectedIndex = -1;
            txtNombreCompleto.Clear();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Usuario usuarioSeleccionado = usuarios[e.RowIndex];

                txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
                txtContraseña.Text = usuarioSeleccionado.Contraseña;
                cboPerfil.SelectedItem = usuarioSeleccionado.Perfil;
                txtNombreCompleto.Text = usuarioSeleccionado.NombreCompleto;
            }
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

                usuarios.Add(nuevoUsuario);
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

                    Usuario usuarioSeleccionado = usuarios[selectedIndex];
                    usuarioSeleccionado.NombreUsuario = nombreUsuario;
                    usuarioSeleccionado.Contraseña = contraseña;
                    usuarioSeleccionado.Perfil = perfil;
                    usuarioSeleccionado.NombreCompleto = nombreCompleto;

                    this.ActualizarGrilla();


                    MessageBox.Show("Usuario modificado con éxito");
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
                    usuarios.RemoveAt(selectedIndex);

                    this.ActualizarGrilla();


                    MessageBox.Show("Usuario eliminado con éxito");
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
