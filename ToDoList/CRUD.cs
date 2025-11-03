using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDoList
{
    internal class CRUD // Clase para manejar las operaciones CRUD en la base de datos
    {
        // Método para AGREGAR una tarea a la base de datos
        public void AgregarTarea(string nombre, string descripcion, bool completada) // No retorna ningún valor, solo realiza la operación
        {
            // Lammamos al metodo conexion() de la clase Conexion para obtener la conexión a la base de datos
            MySqlConnection conexionBD = Conexion.conexion();

            // Manejo de errores con try-catch
            try
            {
                // Establecemo la conexión a la base de datos con el método Open()
                conexionBD.Open();

                // Crear el comando SQL para insertar
                // My sql almacena booleanos como 0 (falso) y 1 (verdadero)
                string query = "INSERT INTO tareas (nombre, descripcion, completada) VALUES ('" + nombre + "', '" + descripcion + "', " + (completada ? 1 : 0) + ")";

                // Crear el objeto comando con la consulta(query) y la conexión(conexionBD) para la conexión abierta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, conexionBD);

                // Ejecutar el comando con ExecuteNonQuery() ya que no esperamos resultados de retorno solo hace la inserción
                comando.ExecuteNonQuery(); // Ejecutar el comando
                
                conexionBD.Close(); // Cerrar la conexión
            }
            catch (Exception ex) // Si hay error
            {
                Console.WriteLine("Error al agregar: " + ex.Message);
            }
        }


        // Método para ELIMINAR una tarea de la base de datos
        public void EliminarTarea(int id)
        {
            // Lammamos al metodo conexion()
            MySqlConnection conexionBD = Conexion.conexion();

            try // Manejo de errores con try-catch
            {
                // Establecemo la conexión a la base de datos con el método Open()
                conexionBD.Open();

                // Crear el comando SQL para eliminar
                string query = "DELETE FROM tareas WHERE id = " + id;

                // Crear el objeto comando con la consulta(query) y la conexión(conexionBD) para la conexión abierta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.ExecuteNonQuery();
                
                conexionBD.Close(); // Cerrar la conexión
            }
            catch (Exception ex) // Si hay error
            {
                Console.WriteLine("Error al eliminar: " + ex.Message);
            }
        }


        // Método para MODIFICAR una tarea en la base de datos
        public void ModificarTarea(int id, string nombre, string descripcion, bool completada)
        {
            MySqlConnection conexionBD = Conexion.conexion(); // Llamamos al método conexion() para obtener la conexión

            try
            {
                conexionBD.Open(); // Abrir la conexión

                // Crear el comando SQL para actualizar con los nuevos valores
                string query = "UPDATE tareas SET nombre = '" + nombre + "', descripcion = '" + descripcion + "', completada = " + (completada ? 1 : 0) + " WHERE id = " + id;

                // Crear el objeto comando con la consulta(query) y la conexión(conexionBD)
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.ExecuteNonQuery(); // Ejecutar el comando
                
                conexionBD.Close(); // Cerrar la conexión
            }
            catch (Exception ex) // Si hay error
            {
                Console.WriteLine("Error al modificar: " + ex.Message);
            }
        }


        // Método para CONSULTAR todas las tareas
        // Creamos el método que retorna un MySqlDataReader que contiene los datos obtenidos de la consulta
        public MySqlDataReader ConsultarTareas()
        {
            // Llamamos al metodo conexion() para obtener la conexión a la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            
            try
            {
                conexionBD.Open(); // Abrir la conexión
                
                // Crear el comando SQL para consultar
                string query = "SELECT * FROM tareas";

                // Crear el objeto comando con la consulta(query) y la conexión(conexionBD), para la conexión abierta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, conexionBD);

                // Envia la consulta para que MySQL lo ejecute
                // Retorna un objeto MySqlDataReader que contiene los datos obtenidos de la consulta
                // Los datos se mantienen en el servidor y se leen bajo demanda, bajo demanda se refiere a que los datos se leen uno por uno cuando se solicitan
                MySqlDataReader leer = comando.ExecuteReader(); // Ejecutar la consulta
                
                return leer; // Retornar los datos

                // La conexion no se cierra aqui porque el MySqlDataReader necesita que la conexion este abierta para leer los datos
                // DataReader necesita la conexion abierta mientras se leen los datos
            }
            catch (Exception ex) // Si hay error
            {
                Console.WriteLine("Error al consultar: " + ex.Message);
                return null;
            }
        }


        // Método para CONSULTAR tareas completadas
        public MySqlDataReader ConsultarTareasCompletas()
        {
            // Llamamos al metodo conexion()
            MySqlConnection conexionBD = Conexion.conexion();
            
            try
            {
                conexionBD.Open(); // Abrir la conexión
                
                // Crear el comando SQL para consultar solo las completadas
                string query = "SELECT * FROM tareas WHERE completada = 1";
                
                MySqlCommand comando = new MySqlCommand(query, conexionBD); // Crear el objeto comando
                MySqlDataReader leer = comando.ExecuteReader(); // Ejecutar la consulta
                
                return leer; // Retornar los datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar completas: " + ex.Message);
                return null;
            }
        }


        // Método para CONSULTAR tareas pendientes
        public MySqlDataReader ConsultarTareasPendientes()
        {
            MySqlConnection conexionBD = Conexion.conexion(); // Llamamos al metodo conexion()

            try
            {
                conexionBD.Open(); // Abrir la conexión
                
                // Crear el comando SQL para consultar solo las pendientes
                string query = "SELECT * FROM tareas WHERE completada = 0";
                
                MySqlCommand comando = new MySqlCommand(query, conexionBD); // Crear el objeto comando
                MySqlDataReader leer = comando.ExecuteReader(); // Ejecutar la consulta
                
                return leer; // Retornar los datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar pendientes: " + ex.Message);
                return null;
            }
        }
    }
}
