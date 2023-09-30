using System;
using System.Collections.Generic;

namespace ControlDeEmpleados
{
    // Enum de tareas relacionadas con el desarrollo de software
    public enum TareasSoftware
    {
        AnalisisRequisitos,
        Diseño,
        Programacion,
        Pruebas,
        Mantenimiento
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public string Genero { get; set; }
        public List<string> Tareas { get; set; }

        public Empleado(string nombre, decimal salario, string genero)
        {
            Nombre = nombre;
            Salario = salario;
            Genero = genero;
            Tareas = new List<string>();
        }

        public void AgregarTarea(string tarea)
        {
            Tareas.Add(tarea);
        }
    }
}
