using JMShopAdmin.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMShopAdmin.DataAccessLayer
{
    public static class ProductoDAO
    {
        /// <summary>
        /// Guarda todos los registros de productos en memoria
        /// </summary>
        public static void GetAll()
        {
            List<Producto> productos = new List<Producto>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM jmshopentity.productos");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto pr = new Producto(reader.GetInt32(0), reader.GetString(6), reader.GetString(5), reader.GetString(7), reader.GetString(3), reader.GetString(8), reader.GetString(4), reader.GetString(1), reader.GetDouble(2));
                    productos.Add(pr);
                }
            }
            reader.Close();
            foreach (Producto us in productos)
            {
                MemoryObjectsDAO.GetListaProductos().Add(us);
            }
        }
        /// <summary>
        /// Crea un un registro de producto en la base de datos.
        /// </summary>
        /// <param name="producto">Objeto producto</param>
        /// <returns>Boolean</returns>
        public static bool CreateProducto(Producto producto)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO jmshopentity.productos VALUES(default, @Descripcion, @Precio, @Cristal, @Diametro, @Marca, @Modelo, @TipoCorrea, @ImagenProducto)");
            command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("@Precio", producto.Precio);
            command.Parameters.AddWithValue("@Cristal", producto.Cristal);
            command.Parameters.AddWithValue("@Diametro", producto.Diametro);
            command.Parameters.AddWithValue("@Marca", producto.Marca);
            command.Parameters.AddWithValue("@Modelo", producto.Modelo);
            command.Parameters.AddWithValue("@TipoCorrea", producto.TipoCorrea);
            command.Parameters.AddWithValue("@ImagenProducto", producto.ImagenProducto);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }
        /// <summary>
        /// Borra un registro de producto en la base de datos
        /// </summary>
        /// <param name="id">Id producto</param>
        /// <returns>Boolean</returns>
        public static bool DeleteProducto(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM jmshopentity.productos WHERE productos.id=@id");
            command.Parameters.AddWithValue("@id", id);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }
        /// <summary>
        /// Edita un registro de producto
        /// </summary>
        /// <param name="p">Id producto</param>
        /// <returns>Boolean</returns>
        public static bool EditProducto(Producto p)
        {
            MySqlCommand command = new MySqlCommand("UPDATE jmshopentity.productos SET productos.Descripcion=@Descripcion, productos.Precio=@Precio, productos.Cristal=@Cristal, productos.Diametro=@Diametro, productos.Marca=@Marca, productos.Modelo=@Modelo, productos.TipoCorrea=@TipoCorrea, productos.ImagenProducto=@ImagenProducto WHERE productos.Id = @id");
            command.Parameters.AddWithValue("@id", p.Id);
            command.Parameters.AddWithValue("@Descripcion", p.Descripcion);
            command.Parameters.AddWithValue("@Precio", p.Precio);
            command.Parameters.AddWithValue("@Cristal", p.Cristal);
            command.Parameters.AddWithValue("@Diametro", p.Diametro);
            command.Parameters.AddWithValue("@Marca", p.Marca);
            command.Parameters.AddWithValue("@Modelo", p.Modelo);
            command.Parameters.AddWithValue("@TipoCorrea", p.TipoCorrea);
            command.Parameters.AddWithValue("@ImagenProducto", p.ImagenProducto);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }
    }
}
