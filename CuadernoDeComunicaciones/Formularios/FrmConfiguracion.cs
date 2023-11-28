using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using BibliotecaClases;

namespace CuadernoDeComunicaciones.Formularios
{
    public partial class FrmConfiguracion : Form
    {
        private string rutaArchivoConfiguraciones = "configuraciones.json"; // Puedes cambiar la ruta según tus necesidades
        private Configuraciones configuraciones;

        public FrmConfiguracion()
        {
            InitializeComponent();
            configuraciones = Configuraciones.CargarConfiguraciones(rutaArchivoConfiguraciones);
            InicializarControles();
        }

        private void InicializarControles()
        {
            // Configura el estado inicial de los controles según las configuraciones
            chkModoOscuro.Checked = configuraciones.ModoOscuro;
            AplicarModoVisual();
        }

        private void AplicarModoVisual()
        {
            // Aplica los cambios visuales según el modo oscuro o claro
            if (configuraciones.ModoOscuro)
            {
                this.BackColor = System.Drawing.Color.DarkGray;


            }
            else
            {
                // Implementa la lógica para el modo claro (colores predeterminados, etc.)
                this.BackColor = System.Drawing.Color.White;
                // ...
            }
        }
        public Configuraciones CargarConfiguracion()
        {
            if (File.Exists("configuraciones.json"))
            {
                string json = File.ReadAllText("configuraciones.json");
                return JsonConvert.DeserializeObject<Configuraciones>(json);
            }

            return new Configuraciones(); // Configuración predeterminada si el archivo no existe
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guarda las configuraciones cuando el usuario hace clic en el botón "Guardar"
            configuraciones.ModoOscuro = chkModoOscuro.Checked;
            configuraciones.GuardarConfiguraciones(rutaArchivoConfiguraciones);

            // Aplica los cambios visuales después de guardar las configuraciones
            AplicarModoVisual();

            MessageBox.Show("Configuraciones guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario actual
            this.Close();

            
        }

        
    }
}
