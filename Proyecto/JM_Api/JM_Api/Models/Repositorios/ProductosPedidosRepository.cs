using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class ProductosPedidosRepository
    {
        /// <summary>
        /// Al añadir un producto al carrito:
        /// 1. Si el usuario no tiene carrito lo crea y añade el producto.
        /// 2. Si tiene carrito pero ese producto no existía crea el registro de la relación.
        /// 3. Si tiene carrito y también existe el registro del producto, añade una unidad al campo cantidad.
        /// </summary>
        /// <param name="idProd">Id producto</param>
        /// <param name="idUser">Id usuario</param>
        internal void AnyadirProductoAlCarrito(int idProd, int idUser)
        {
            JMContext context = new JMContext();
            //Creamos un objeto pedido para trazar si tenemos un carrito con ese usuario
            Pedido pedidoTrazador = new Pedido();
            pedidoTrazador = context.Pedidos
                    .Where(p => p.UsuarioId == idUser && p.EsCarrito == true)
                    .FirstOrDefault();

            //Obtenemos el objeto del producto añadido para poder usar el campo precio.
            Producto producto = new Producto();
            producto = context.Productos
                .Where(pr => pr.Id == idProd)
                .FirstOrDefault();

            //Comprobamos si existe un carrito-pedido para ese usuario
            if (object.Equals(null, pedidoTrazador))
            {
                Pedido pedido = new Pedido();
                pedido.UsuarioId = idUser;
                pedido.FechaCreacion = DateTime.Now;
                pedido.EsCarrito = true;
                context.Pedidos.Add(pedido);
                context.SaveChanges();
                //volvemos a cargar el pedido que acabamos de añadir para poder rescatar la id autogenerada.
                pedido = context.Pedidos
                        .Where(p => p.UsuarioId == idUser && p.EsCarrito == true)
                        .FirstOrDefault();

                ProductoPedido pp = new ProductoPedido();
                pp.Cantidad = 1;
                pp.ProductoId = idProd;
                pp.PedidoId = pedido.PedidoId;
                pp.Total = producto.Precio * pp.Cantidad;
                context.ProductosPedidos.Add(pp);
                context.SaveChanges();
            }
            else
            {
                //Si el usuario ya tiene un pedido-carrito rescatamos todos los productos del carrito para comprobar si alguno ya ha sido añadido anteriormente y, 
                //por lo tanto, aumentar en una unidad la cantidad en vez de volver a insertar un registro.
                bool existeProducto = false;
                List<ProductoPedido> listaPP = new List<ProductoPedido>();
                listaPP = context.ProductosPedidos
                    .Where(pp => pp.PedidoId == pedidoTrazador.PedidoId)
                    .ToList();

                foreach (ProductoPedido pp in listaPP)
                {
                    if(pp.ProductoId == producto.Id)
                    {
                        existeProducto = true;
                        pp.Cantidad += 1;
                        pp.Total = pp.Cantidad * producto.Precio;
                        context.SaveChanges();
                        break;
                    }
                }
                //En caso de que el producto no esté aún en el carrito, lo añade.
                if (!existeProducto)
                {
                    ProductoPedido pp = new ProductoPedido();
                    pp.Cantidad = 1;
                    pp.ProductoId = idProd;
                    pp.PedidoId = pedidoTrazador.PedidoId;
                    pp.Total = producto.Precio * pp.Cantidad;
                    context.ProductosPedidos.Add(pp);
                    context.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Resta una unidad a la cantidad de un producto del carrito, si llega a 0, en su lugar elimina el registro.
        /// </summary>
        /// <param name="ppId">Id productopedido</param>
        internal void RestarUnidadProductoDeCarrito(int ppId)
        {
            JMContext context = new JMContext();

            ProductoPedido pp = new ProductoPedido();
            pp = context.ProductosPedidos
                .Where(p => p.ProductoPedidoId == ppId)
                .FirstOrDefault();

            Producto producto = new Producto();
            producto = context.Productos
                .Where(p => p.Id == pp.ProductoId)
                .FirstOrDefault();
            
            pp.Cantidad -= 1;
            pp.Total = pp.Cantidad * producto.Precio;
            if(pp.Cantidad == 0)
            {
                context.ProductosPedidos.Remove(pp);
            }
            context.SaveChanges();
        }
        /// <summary>
        /// Añade una unidad a la cantidad de un producto del carrito
        /// </summary>
        /// <param name="ppId">Id productopedido</param>
        internal void SumarUnidadProductoDeCarrito(int ppId)
        {
            JMContext context = new JMContext();

            ProductoPedido pp = new ProductoPedido();
            pp = context.ProductosPedidos
                .Where(p => p.ProductoPedidoId == ppId)
                .FirstOrDefault();

            Producto producto = new Producto();
            producto = context.Productos
                .Where(p => p.Id == pp.ProductoId)
                .FirstOrDefault();

            pp.Cantidad += 1;
            pp.Total = pp.Cantidad * producto.Precio;
            context.SaveChanges();
        }
        /// <summary>
        /// Convierte un objeto productopedido a un productopedidoDTO
        /// </summary>
        /// <param name="pp">Objeto ProductoPedido</param>
        /// <returns></returns>
        public static ProductoPedidoDTO ToDTO(ProductoPedido pp)
        {
            return new ProductoPedidoDTO(pp.ProductoPedidoId, pp.Cantidad, pp.Total, pp.Producto.Marca, pp.Producto.Modelo, pp.Producto.ImagenProducto, pp.Producto.Precio, pp.PedidoId, pp.ProductoId);
        }
        /// <summary>
        /// Lista los productos del carrito de un usuario, y lo pasa a DTO.
        /// </summary>
        /// <param name="idUser">Id usuario</param>
        /// <returns>Lista productopedidoDTO</returns>
        internal List<ProductoPedidoDTO> ListarProductosCarrito(int idUser)
        {
            JMContext context = new JMContext();

            List<ProductoPedidoDTO> productos = new List<ProductoPedidoDTO>();

            productos = context.ProductosPedidos.Include(pp => pp.Pedido ).Include(pp => pp.Producto).Where(s => s.Pedido.EsCarrito == true && s.Pedido.UsuarioId == idUser).Select(a => ToDTO(a)).ToList();
            return productos;
        }
        /// <summary>
        /// Lista los productos de un pedido realizado, mediante su Id.
        /// </summary>
        /// <param name="idPedido">Id pedido</param>
        /// <returns>Lista productopedidoDTO</returns>
        internal List<ProductoPedidoDTO> ListarProductosPedido(int idPedido)
        {
            JMContext context = new JMContext();

            List<ProductoPedidoDTO> productos = new List<ProductoPedidoDTO>();

            productos = context.ProductosPedidos.Include(pp => pp.Pedido).Include(pp => pp.Producto).Where(s => s.Pedido.PedidoId == idPedido).Select(a => ToDTO(a)).ToList();
            return productos;
        }
    }
}