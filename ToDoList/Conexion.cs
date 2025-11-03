using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoList
{
    // Clase para manejar la conexión a MySQL
    internal class Conexion
    {
        // Método que retorna la conexión a la base de datos
        public static MySqlConnection conexion()
        {
            // Datos de conexión
            string servidor = "localhost";
            string bd = "todolist";
            string usuario = "root";
            string password = "1234"; 

            // Se crea la cadena de conexión con los datos anteriormente guardados
            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";

            // Hacemos un manejo de errores con try-catch
            try 
            {
                // Crear el objeto de conexión con la cadena de conexión
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion); 

                // Retornar la conexión
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                // En caso de que no se pueda conectar a MySQL, se muestra el mensaje de error
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
