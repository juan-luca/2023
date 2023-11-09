using System;
using System.Data.SqlClient;


namespace BibliotecaClases
{

    
    public static class ConexionBD
    {
        private static readonly string CadenaConexion = "tu_cadena_de_conexion";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                Console.WriteLine("Conexión abierta correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }

            return conexion;
        }

        public static void CerrarConexion(SqlConnection conexion)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }

}
