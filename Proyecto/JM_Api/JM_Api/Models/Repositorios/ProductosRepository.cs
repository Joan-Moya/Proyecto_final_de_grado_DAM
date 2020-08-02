using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class ProductosRepository
    {
        /// <summary>
        /// Recupera la lista de productos
        /// </summary>
        /// <returns>Lista productos</returns>
        internal List<Producto> Retrieve()
        {
            List<Producto> arrayProd = new List<Producto>();
            using(JMContext context = new JMContext())
            {
                arrayProd = context.Productos
                    .ToList();
            }
            return arrayProd;
        }
        /// <summary>
        /// Recupera la lista productos de una marca.
        /// </summary>
        /// <param name="marca">Marca de producto</param>
        /// <returns>Lista de productos</returns>
        internal List<Producto> RetrieveByMark(string marca)
        {
            List<Producto> arrayProd = new List<Producto>();
            using (JMContext context = new JMContext())
            {
                arrayProd = context.Productos
                    .Where(p => p.Marca == marca)
                    .ToList();
            }
            return arrayProd;
        }
    }
}