using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class InformacionPagoDAO
    {
        /// <summary>
        /// Guarda todos los registros de información de pago en memória.
        /// </summary>
        public static void GetAll()
        {
            List<InformacionPago> informacionpagos = new List<InformacionPago>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.informacionpagos");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    InformacionPago ip = new InformacionPago(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4), reader.GetInt32(5));
                    informacionpagos.Add(ip);
                }
            }
            reader.Close();
            foreach (InformacionPago ip in informacionpagos)
            {
                MemoryObjectsDAO.GetListaListaInformacionPagos().Add(ip);
            }
        }
    }
}
