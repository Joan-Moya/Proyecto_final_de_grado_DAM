using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class DireccionEnvioDAO
    {
        /// <summary>
        /// Guarda todos los registros de direcciones de envío en memoria
        /// </summary>
        public static void GetAll()
        {
            List<DireccionEnvio> direccionesenvio = new List<DireccionEnvio>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.direccionesenvio");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)// comprueba que el registro devuelto no sea nulo.
            {
                while (reader.Read())//  El método Read() va a intentar mover el lector al siguiente registro que es necesario procesar, en el caso que sea posible avanzar a la siguiente fila, ya que hay mas filas para frocesar devolvera true, si ya no quedan filas devuelve falso.
                {
                    DireccionEnvio de = new DireccionEnvio(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7));
                    direccionesenvio.Add(de);
                }
            }
            reader.Close();
            foreach (DireccionEnvio de in direccionesenvio)
            {
                MemoryObjectsDAO.GetListaListaDireccionesEnvio().Add(de);//Añadimos los productos a la memoria de MemoryObjectsDAO.
            }
        }
    }
}
