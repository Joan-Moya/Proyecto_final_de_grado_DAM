using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public class Database
    {
        private static MySqlConnection connection;

        /// <summary>
        /// Método para establecer conexión con la base de datos.
        /// </summary>
        /// <returns>Booleano indicando si se ha podido establecer la conexión.</returns>
        public static bool Connect()
        {
            string connectionString = "Server=localhost;user=root;database=jmshopentity;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para desconectarse de la BBDD.
        /// </summary>
        public static void Disconnect()
        {
            connection.Close();
        }

        /// <summary>
        /// Metodo que que va a hacer es ejecutar un query y devuelve un MySQL datareader con los registros.
        /// </summary>
        /// <param name="command">Sentencia MySql</param>
        /// <returns>Registros de la consulta</returns>
        public static MySqlDataReader ExecuteQuery(MySqlCommand command)
        {
            command.Connection = connection;//asociamos una conexión al comando
            command.Prepare();//una vez hayamos asociado el objecto de conexión al comando sql en principio lo preparamos, para esa consulta que lanzamos a la base de datos este lista para ser ejecutada.
            return command.ExecuteReader();//ExecuteReader lo que hace es generar el comando con tipo de dato MySqlDataReader, que como resultado va a generar filas y columnas.
        }
        /// <summary>
        /// Para ejecutar otros comandos que no son consultas.
        /// </summary>
        /// <param name="command">Comando</param>
        /// <returns>Número de filas afectadas por este comando.</returns>
        public static int ExecuteNonQuery(MySqlCommand command)
        {
            command.Connection = connection;
            command.Prepare();
            return command.ExecuteNonQuery(); //El número int que se devuelve representa el número de filas afectadas por ese commando.
        }
    }
}
