using BibliotecaClases;
/// <summary>
/// Clase que representa a un estudiante.
/// </summary>
public class Alumno : Usuario
{
    /// <summary>
    /// Obtiene o establece el nombre del padre del estudiante.
    /// </summary>
    public string Padre { get; set; }
    public string Division{ get; set; }
    /// <summary>
    /// Obtiene o establece el nombre de la madre del estudiante.
    /// </summary>
    public string Madre { get; set; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase Alumno.
    /// </summary>
    /// <param name="nombreUsuario">Nombre de usuario del alumno.</param>
    /// <param name="contraseña">Contraseña del alumno.</param>
    /// <param name="perfil">Perfil del alumno.</param>
    /// <param name="nombreCompleto">Nombre completo del alumno.</param>
    /// <param name="padre">Nombre del padre del alumno.</param>
    /// <param name="madre">Nombre de la madre del alumno.</param>
    public Alumno(string nombreUsuario, string contraseña, string perfil, string nombreCompleto, string padre, string madre, string division)
        : base(nombreUsuario, contraseña, perfil, nombreCompleto)
    {
        this.Padre = padre;
        this.Madre = madre;
        this.Division= division;
    }
}
