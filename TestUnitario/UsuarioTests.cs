using BibliotecaClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void CrearUsuario_Valido()
        {
            // Arrange
            Usuario usuario = new Usuario
            {
                NombreUsuario = "TestUser",
                Contraseña = "TestPassword",
                Perfil = Perfil.Alumno.ToString(),
                NombreCompleto = "Test User"
            };

            // Act
            bool resultado = usuario.Crear();

            // Assert
            NUnit.Framework.Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ModificarUsuario_Existente()
        {
            // Arrange
            Usuario usuario = new Usuario
            {
                NombreUsuario = "UsuarioExistente",
                Contraseña = "OldPassword",
                Perfil = Perfil.Alumno.ToString(),
                NombreCompleto = "Usuario Existente"
            };

            // Act
            bool resultadoCreacion = usuario.Crear();

            // Assert
            NUnit.Framework.Assert.IsTrue(resultadoCreacion);

            // Arrange para la modificación
            Usuario usuarioModificado = new Usuario
            {
                NombreUsuario = "UsuarioExistente",
                Contraseña = "NewPassword",
                Perfil = Perfil.Profesor.ToString(),
                NombreCompleto = "Usuario Modificado"
            };

            // Act
            bool resultadoModificacion = usuarioModificado.Modificar();

            // Assert
            NUnit.Framework.Assert.IsTrue(resultadoModificacion);
        }

        // Puedes seguir este patrón para otras pruebas como Borrar, ListarTodos, etc.
    }
}
