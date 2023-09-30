using System;

public class Empleado
{
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public decimal Salario { get; set; }
    public Tarea TareaAsignada { get; set; } // Propiedad que representa la tarea asignada al empleado.

    public Empleado(string nombre, string genero, decimal salario, Tarea tareaAsignada)
    {
        Nombre = nombre;
        Genero = genero;
        Salario = salario;
        TareaAsignada = tareaAsignada;
    }

    // Sobrescribe el método ToString para mostrar la información del empleado.
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Género: {Genero}, Salario: {Salario:C}, Tarea: {TareaAsignada}";
    }
}
