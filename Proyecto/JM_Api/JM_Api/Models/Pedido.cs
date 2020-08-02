using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class Pedido
    {

        public Pedido()
        {
            EsCarrito = false;
            FechaCreacion = DateTime.MinValue;
            UsuarioId = -1;
        }

        public Pedido(int pedidoId, bool esCarrito, DateTime fechaCreacion, int usuarioId)
        {
            PedidoId = pedidoId;
            
            EsCarrito = esCarrito;
            FechaCreacion = fechaCreacion;
            UsuarioId = usuarioId;
            
        }

        public int PedidoId { get; set; }
        public bool EsCarrito { get; set; }
        
        public DateTime FechaCreacion { get; set; }

        public List<ProductoPedido> ProductosPedidos { get; set; }

        public Transaccion Transaccion { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        

    }
}