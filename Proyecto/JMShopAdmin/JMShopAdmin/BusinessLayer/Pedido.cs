using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioId { get; set; }
        public bool EsCarrito { get; set; }

        public Pedido()
        {
        }

        public Pedido(int pedidoId, DateTime fechaCreacion, int usuarioId, bool esCarrito)
        {
            PedidoId = pedidoId;
            FechaCreacion = fechaCreacion;
            UsuarioId = usuarioId;
            EsCarrito = esCarrito;
        }
    }
}
