using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class AdministradorDAO
    {
        /// <summary>
        /// Guarda todos los registros de la tabla administradores en memeoria.
        /// </summary>
        public static void GetAll()
        {
            List<Administrador> administradores = new List<Administrador>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.administradores");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)// comprueba que el registro devuelto no sea nulo.
            {
                while (reader.Read())//  El método Read() va a intentar mover el lector al siguiente registro que es necesario procesar, en el caso que sea posible avanzar a la siguiente fila, ya que hay mas filas para frocesar devolvera true, si ya no quedan filas devuelve falso.
                {
                    Administrador admin = new Administrador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    administradores.Add(admin);
                }
            }
            reader.Close();
            foreach (Administrador ad in administradores)
            {
                MemoryObjectsDAO.GetListaAdministradores().Add(ad);//Añadimos los administradoes a la memoria de MemoryObjectsDAO.
            }
        }
    }
}
