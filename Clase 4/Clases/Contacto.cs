
namespace Clases
{
    
public class Contacto
{
    #region Atributos Privados

    private string nombre;
    private string numeroTelefono;

    #endregion

    #region Propiedades Públicas

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string NumeroTelefono
    {
        get { return numeroTelefono; }
        set { numeroTelefono = value; }
    }

    #endregion

    #region Constructor

    public Contacto(string nombre, string numeroTelefono)
    {
        this.nombre = nombre;
        this.numeroTelefono = numeroTelefono;
    }

    #endregion
}

}
