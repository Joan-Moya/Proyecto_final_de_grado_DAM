using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class TransaccionesRepository
    {
        /// <summary>
        /// Realiza un pedido.
        /// </summary>
        /// <param name="idPedido">Id pedido</param>
        /// <param name="idDirEnvio">Id dirección envío</param>
        /// <param name="idInfoPago">Id información de pago</param>
        /// <param name="notasEntrega">Notas de entrega</param>
        internal void RealizarPedido(int idPedido, int idDirEnvio, int idInfoPago, string notasEntrega)
        {
            JMContext context = new JMContext();
            List<ProductoPedido> listaPP = new List<ProductoPedido>();
            listaPP = context.ProductosPedidos
                .Where(p => p.PedidoId == idPedido)
                .ToList();

            if (listaPP.Any())
            {
                Pedido pedido = new Pedido();
                pedido = context.Pedidos
                    .Where(ped => ped.PedidoId == idPedido)
                    .FirstOrDefault();

                double totalPedido = 0;
                foreach (ProductoPedido pp in listaPP)
                {
                    totalPedido += pp.Total;
                }

                Transaccion transaccion = new Transaccion();
                transaccion.Total = totalPedido;
                //Aqui en teoria tendría que checkear si el pago se realiza correctamente, como no podemos realizar un pago real supondremos que no se realiza el pago correctamente.
                transaccion.PagoRealizado = false;
                if (transaccion.PagoRealizado)
                {
                    transaccion.Estado = "Preparando pedido";
                }
                else
                {
                    transaccion.Estado = "Pendiente de pago";
                }
                transaccion.FechaCreacion = DateTime.Now;
                transaccion.FechaEntrega = DateTime.Now.AddDays(3);
                transaccion.NotasEntrega = notasEntrega;
                transaccion.PedidoId = idPedido;
                transaccion.DireccionEnvioId = idDirEnvio;
                transaccion.InformacionPagoId = idInfoPago;
                context.Add(transaccion);
                //Fijas el campo EsCarrito a false, de esta forma pasa a ser un pedido realizado y la próxima vez que el usuario añada un producto creara un carrito-pedido nuevo.
                pedido.EsCarrito = false;
                context.SaveChanges();
            }    
        }
        /// <summary>
        /// Recupera los pedidos realizados por un usuario.
        /// </summary>
        /// <param name="idUsuario">Id usuario</param>
        /// <returns>Lista transacciones</returns>
        internal List<Transaccion> RetrievePedidosRealizados(int idUsuario)
        {
            JMContext context = new JMContext();

            List<Transaccion> pedidos = new List<Transaccion>();
            pedidos = context.Transacciones.Where(t => t.Pedido.EsCarrito == false && t.Pedido.UsuarioId == idUsuario).ToList();
            return pedidos;
        }
    }
}