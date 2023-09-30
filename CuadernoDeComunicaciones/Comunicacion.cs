using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuadernoDeComunicaciones
{
    public class Comunicacion : Elemento
    {
        #region Atributos
        private int comunicacionNro;
        private Categoria categoria;
        private string texto;
        protected string archivoXml = "Comunicaciones.xml";
        #endregion

        #region Constructor
        public Comunicacion()
        {
            
        }
        public Comunicacion( string Remitente,  string Alumno, int ComunicacionNro, Categoria Categoria, string Texto, DateTime Fecha)
            : base(Remitente, Alumno,Fecha)
        {
            this.comunicacionNro = ComunicacionNro;
            this.categoria = Categoria;
            this.texto = Texto;
        }
        #endregion

        #region Métodos Públicos
        public override bool Crear()
        {
            return this.AgregarComunicacionAXml();

        }

        public override void Modificar()
        {
            // Implementar la lógica para modificar una comunicación
        }

        public override void Borrar()
        {
            // Implementar la lógica para borrar una comunicación
        }

        public static List<Comunicacion> ListarTodos()
        {
           
            return Comunicacion.DeserializarComunicaciones();
        }

        public override Elemento Buscar()
        {
            Elemento comunicacionEncontrada = null;
            // Implementar la lógica para buscar una comunicación
            return comunicacionEncontrada;
        }
        #endregion
        private bool AgregarComunicacionAXml()
        {
            List<Comunicacion> comunicaciones = Comunicacion.ListarTodos();

            comunicaciones.Add(this);

            return SerializarComunicaciones(comunicaciones, archivoXml);

        }
        public static List<Comunicacion> DeserializarComunicaciones()
        {
            List<Comunicacion> comunicaciones = new List<Comunicacion>();
            string archivoXml = "Comunicaciones.xml";
            if (File.Exists(archivoXml))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Comunicacion>));
                    using (FileStream fs = new FileStream(archivoXml, FileMode.Open))
                    {
                        comunicaciones = (List<Comunicacion>)serializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deserializar: " + ex.Message);
                }
            }

            return comunicaciones;
        }
        public static bool SerializarComunicaciones(List<Comunicacion> comunicaciones, string archivoXml)
        {
            bool Serializado=false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Comunicacion>));
                using (FileStream fs = new FileStream(archivoXml, FileMode.Create))
                {
                    serializer.Serialize(fs, comunicaciones);
                    Serializado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al serializar: " + ex.Message);
            }
            return Serializado;
        }

        #region Propiedades Públicas
        public int ComunicacionNro
        {
            get { return this.comunicacionNro; }
            set { this.comunicacionNro = value; }
        }

        public Categoria Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string Texto
        {
            get { return this.texto; }
            set { this.texto = value; }
        }

        #endregion
    }
}
