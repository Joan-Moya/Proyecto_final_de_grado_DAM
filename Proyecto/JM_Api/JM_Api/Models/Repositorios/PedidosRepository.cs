using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class PedidosRepository
    {
        /// <summary>
        /// Borra un pedido.
        /// </summary>
        /// <param name="idPedido">Id pedido</param>
        internal void Delete(int idPedido)
        {
            using (JMContext context = new JMContext())
            {
                context.Pedidos.Remove(context.Pedidos.Where(p => p.PedidoId == idPedido).FirstOrDefault());
                context.SaveChanges();
            }
        }
    }
}