using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlDeEmpleados
{
    public partial class Form1 : Form
    {
        // Lista para almacenar empleados
        private List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();

            // Cargar el ComboBox de tareas con los valores del enum
            CargarComboBoxTareas();

            // Configurar la DataGridView de empleados
            dataGridViewEmpleados.AutoGenerateColumns = true;
            dataGridViewEmpleados.DataSource = empleados;

            // Configurar la DataGridView de tareas
            dataGridViewTareas.AutoGenerateColumns = false;
        }

        private void CargarComboBoxTareas()
        {
            // Obtener los valores del enum TareasSoftware y agregarlos al ComboBox
            comboBoxTareas.DataSource = Enum.GetValues(typeof(TareasSoftware));
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Obtener el género seleccionado
            string genero = "";
            if (chkMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (chkFemenino.Checked)
            {
                genero = "Femenino";
            }

            // Obtener la tarea seleccionada
            string tarea = comboBoxTareas.SelectedItem as string;

            // Crear un nuevo empleado y agregarlo a la lista
            Empleado empleado = new Empleado(nombre, salario, genero);
            if (!string.IsNullOrEmpty(tarea))
            {
                empleado.AgregarTarea(tarea);
            }
            empleados.Add(empleado);

            // Limpiar los campos del formulario
            LimpiarCampos();

            // Actualizar la DataGridView de empleados
            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleados;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtSalario.Clear();
            chkMasculino.Checked = false;
            chkFemenino.Checked = false;
            comboBoxTareas.SelectedIndex = -1;
        }

        private void dataGridViewEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            // Obtener el empleado seleccionado
            Empleado empleadoSeleccionado = dataGridViewEmpleados.CurrentRow.DataBoundItem as Empleado;

            // Mostrar las tareas del empleado en la DataGridView de tareas
            if (empleadoSeleccionado != null)
            {
                dataGridViewTareas.DataSource = empleadoSeleccionado.Tareas;
            }
        }
    }
}
