using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class InformacionesPagoRepositoy
    {
        /// <summary>
        /// Recupera la lista de métodos de pago de un usuario
        /// </summary>
        /// <returns>Lista métodos de pago</returns>
        internal List<InformacionPago> Retrieve()
        {
            List<InformacionPago> arrayIngPago = new List<InformacionPago>();
            using (JMContext context = new JMContext())
            {
                arrayIngPago = context.InformacionPagos
                    .ToList();
            }
            return arrayIngPago;
        }
        /// <summary>
        /// Recupera la lista de métodos de pago de un usuario.
        /// </summary>
        /// <param name="userId">Id usuario</param>
        /// <returns>Lista métodos de pago</returns>
        internal List<InformacionPago> RetrieveByUser(int userId)
        {
            List<InformacionPago> arrayIngPago = new List<InformacionPago>();
            using (JMContext context = new JMContext())
            {
                arrayIngPago = context.InformacionPagos
                    .Where(i => i.UsuarioId == userId)
                    .ToList();
            }
            return arrayIngPago;
        }
        /// <summary>
        /// Recupera el objeto de un método de pago a través del pedido Id.
        /// </summary>
        /// <param name="pedidoId">Id pedido</param>
        /// <returns>Objeto metodo de pago</returns>
        internal InformacionPago RetrieveInfoPagoPedido(int pedidoId)
        {
            JMContext context = new JMContext();

            Transaccion transaccion = new Transaccion();
            transaccion = context.Transacciones.Where(t => t.PedidoId == pedidoId).FirstOrDefault();

            InformacionPago infoPago = new InformacionPago();
            infoPago = context.InformacionPagos.Where(i => i.InformacionPagoId == transaccion.InformacionPagoId).FirstOrDefault();

            return infoPago;
        }
        /// <summary>
        /// Guarda un método de pago en la base de datos.
        /// </summary>
        /// <param name="infpago">Objeto informacion de pago</param>
        internal void Save(InformacionPago infpago)
        {
            JMContext context = new JMContext();
            context.InformacionPagos.Add(infpago);
            context.SaveChanges();
        }
        /// <summary>
        /// Borra un método de pago en la base de datos.
        /// </summary>
        /// <param name="id">Id informacion de pago</param>
        internal void Delete(int id)
        {
            using (JMContext context = new JMContext())
            {
                context.InformacionPagos.Remove(context.InformacionPagos.Where(i => i.InformacionPagoId == id).FirstOrDefault());
                context.SaveChanges();
            }
        }
    }
}