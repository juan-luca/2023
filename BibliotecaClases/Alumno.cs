using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaClases
{
    public class Alumno : Usuario
    {
        public string Padre { get; set; }
        public string Madre { get; set; }

        public Alumno(string nombreUsuario, string contraseña, string perfil, string nombreCompleto, string padre, string madre)
            : base(nombreUsuario, contraseña, perfil, nombreCompleto)
        {
            this.Padre = padre;
            this.Madre = madre;
        }

        
    }

}
