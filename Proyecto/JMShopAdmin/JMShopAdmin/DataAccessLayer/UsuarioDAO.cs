using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class UsuarioDAO
    {
        /// <summary>
        /// Guarda todos los registros de usuario en memoria
        /// </summary>
        public static void GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.usuarios");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario us = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                    usuarios.Add(us);
                }
            }
            reader.Close();
            foreach (Usuario us in usuarios)
            {
                MemoryObjectsDAO.GetListaUsuarios().Add(us);
            }
        }
    }
}
