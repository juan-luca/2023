using System;
using System.Collections.Generic;

namespace CuadernoDeComunicaciones
{
    [Serializable]
    public class Usuario
    {
        #region Atributos
        private string nombreUsuario;
        private string contraseña;
        private string perfil;
        private string nombreCompleto;
        #endregion

        #region Propiedades
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        #endregion

        #region Constructor
        public Usuario()
        {
            
        }
        public Usuario(string NombreUsuario, string Contraseña, string Perfil, string NombreCompleto)
        {
            this.nombreUsuario = NombreUsuario;
            this.contraseña = Contraseña;
            this.perfil = Perfil;
            this.nombreCompleto = NombreCompleto;
        }
        #endregion

    }
}
