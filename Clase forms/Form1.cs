using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Clase_forms
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;

            // Cargar el ComboBox con las tareas del enum.
            cbTareas.DataSource = Enum.GetValues(typeof(Tarea));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string genero = rdFemenino.Checked ? "Femenino" : rdMasculino.Checked ? "Masculino" : "";

            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal salario;

            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tarea tareaAsignada = (Tarea)cbTareas.SelectedItem; // Obtener la tarea seleccionada en el ComboBox.

            Empleado empleado = new Empleado(nombre, genero, salario, tareaAsignada);
            bindingSource.Add(empleado);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtSalario.Text = "";
            rdFemenino.Checked = false;
            rdMasculino.Checked = false;
            cbTareas.SelectedIndex = 0; // Establecer la primera tarea como seleccionada por defecto.
        }
    }
}
