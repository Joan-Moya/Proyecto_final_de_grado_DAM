using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class PedidoDAO
    {
        /// <summary>
        /// Guarda todos los registros de pedidos en memoria.
        /// </summary>
        public static void GetAll()
        {
            List<Pedido> productospedidos = new List<Pedido>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.pedidos");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido ped = new Pedido(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetBoolean(3));
                    productospedidos.Add(ped);
                }
            }
            reader.Close();
            foreach (Pedido ped in productospedidos)
            {
                MemoryObjectsDAO.GetListaPedidos().Add(ped);
            }
        }
        /// <summary>
        /// Borra un pedido de la base de datos a través de su Id.
        /// </summary>
        /// <param name="id">Id pedido</param>
        /// <returns>Boolean</returns>
        public static bool DeletePedido(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM jmshopentity.pedidos WHERE pedidos.id=@id");
            command.Parameters.AddWithValue("@id", id);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }
    }
}
