using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class ProductoPedidoDAO
    {
        /// <summary>
        /// Guarda todos los registros de productospedidos en memoria
        /// </summary>
        public static void GetAll()
        {
            List<ProductoPedido> productospedidos = new List<ProductoPedido>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.productospedidos");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductoPedido pp = new ProductoPedido(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4));
                    productospedidos.Add(pp);
                }
            }
            reader.Close();
            foreach (ProductoPedido pp in productospedidos)
            {
                MemoryObjectsDAO.GetListaProductosPedidos().Add(pp);
            }
        }
    }
}
