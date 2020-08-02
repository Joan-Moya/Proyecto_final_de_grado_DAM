using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class ProductoPedido
    {
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

        public int ProductoPedidoId { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto {get; set;}
    }

    public class ProductoPedidoDTO
    {
        public ProductoPedidoDTO(int productoPedidoId, int cantidad, double total,  string marca, string modelo, string imagenProducto, double precio, int pedidoId, int productoId)
        {
            Cantidad = cantidad;
            Total = total;
            Modelo = modelo;
            Marca = marca;
            Precio = precio;
            ImagenProducto = imagenProducto;
            PedidoId = pedidoId;
            ProductoId = productoId;
            ProductoPedidoId = productoPedidoId;
        }

        public ProductoPedidoDTO()
        {
        }
        public int ProductoPedidoId { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
        [MaxLength(30)]
        public string Modelo { get; set; }
        [MaxLength(20)]
        public string Marca { get; set; }
        public double Precio { get; set; }
        [MaxLength(100)]
        public string ImagenProducto { get; set; }

    
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}