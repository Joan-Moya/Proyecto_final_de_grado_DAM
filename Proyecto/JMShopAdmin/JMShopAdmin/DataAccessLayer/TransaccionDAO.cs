using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class TransaccionDAO
    {
        /// <summary>
        /// Guarda todos los registros de transacciones en memoria
        /// </summary>
        public static void GetAll()
        {
            List<Transaccion> transacciones = new List<Transaccion>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.transacciones");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Transaccion tr = new Transaccion(reader.GetInt32(0), reader.GetDouble(1), reader.GetString(8), reader.GetDateTime(9), reader.GetBoolean(7), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                    transacciones.Add(tr);
                }
            }
            reader.Close();
            foreach (Transaccion tr in transacciones)
            {
                MemoryObjectsDAO.GetListaTransacciones().Add(tr);
            }
        }
        /// <summary>
        /// Edita el estado de un registro de transacción en la base de datos.
        /// </summary>
        /// <param name="id">Id transacción</param>
        /// <param name="estado">Estado</param>
        /// <returns>Boolean</returns>
        public static bool EditTransaccion(int id, string estado)
        {
            MySqlCommand command = new MySqlCommand("UPDATE jmshopentity.transacciones SET transacciones.Estado=@estado WHERE transacciones.TransaccionId = @id");
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@estado", estado);
            int rows = Database.ExecuteNonQuery(command);// Ejecutamos el comando no siendo un comando de consulta, es decir no te devuelve filas como si lo hace el SELECT x ejemplo. Te devuelve el numero de filas afectadas que las guardaremos en la variable rows.
            return rows >= 1;//devuelve true si rows es igual o mayor que 1.
        }
    }
}
