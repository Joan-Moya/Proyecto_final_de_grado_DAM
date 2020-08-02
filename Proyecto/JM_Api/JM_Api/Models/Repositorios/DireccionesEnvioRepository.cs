using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class DireccionesEnvioRepository
    {
        /// <summary>
        /// Devuelve una lista con todas la direcciones de envio
        /// </summary>
        /// <returns>Lista direcciones de envío</returns>
        internal List<DireccionEnvio> Retrieve()
        {
            List<DireccionEnvio> arrayDirEnv = new List<DireccionEnvio>();
            using (JMContext context = new JMContext())
            {
                arrayDirEnv = context.DireccionesEnvio
                    .ToList();
            }
            return arrayDirEnv;
        }
        /// <summary>
        /// Devuelve una lista con todas las direcciones de un usuario.
        /// </summary>
        /// <param name="userId">Id usuario</param>
        /// <returns>Lista usuarios</returns>
        internal List<DireccionEnvio> RetrieveByUser(int userId)
        {
            List<DireccionEnvio> arrayDirEnv = new List<DireccionEnvio>();
            using (JMContext context = new JMContext())
            {
                arrayDirEnv = context.DireccionesEnvio
                    .Where(d => d.UsuarioId == userId)
                    .ToList();
            }
            return arrayDirEnv;
        }
        /// <summary>
        /// Devuelve la dirección de envio de un pedido realizado.
        /// </summary>
        /// <param name="pedidoId">Id pedido</param>
        /// <returns>Objeto pedido</returns>
        internal DireccionEnvio RetrieveDireccionPedido(int pedidoId)
        {
            JMContext context = new JMContext();

            Transaccion transaccion = new Transaccion();
            transaccion = context.Transacciones.Where(t => t.PedidoId == pedidoId).FirstOrDefault();

            DireccionEnvio dirEnv = new DireccionEnvio();
            dirEnv = context.DireccionesEnvio.Where(d => d.DireccionEnvioId == transaccion.DireccionEnvioId).FirstOrDefault();

            return dirEnv;
        }
        /// <summary>
        /// Guarda una dirección de envío en la base de datos
        /// </summary>
        /// <param name="dir">Objeto direccion de envio</param>
        internal void Save(DireccionEnvio dir)
        {
            JMContext context = new JMContext();
            context.DireccionesEnvio.Add(dir);
            context.SaveChanges();
        }
        /// <summary>
        /// Borra una dirección de envío en la base de datos.
        /// </summary>
        /// <param name="id">Id direccion de envío</param>
        internal void Delete(int id)
        {
            using (JMContext context = new JMContext())
            {
                context.DireccionesEnvio.Remove(context.DireccionesEnvio.Where(d => d.DireccionEnvioId == id).FirstOrDefault());
                context.SaveChanges();
            }
        }
    }
}