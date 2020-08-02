using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class ProductoPedido
    {
        public int ProductoPedidoId { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public int PedidoId { get; set; }
        public int ProductoId { get; set; }

        public ProductoPedido(int productoPedidoId, int cantidad, double total, int pedidoId, int productoId)
        {
            ProductoPedidoId = productoPedidoId;
            Cantidad = cantidad;
            Total = total;
            PedidoId = pedidoId;
            ProductoId = productoId;
        }

        public ProductoPedido()
        {
        }
    }
}
