using JM_Api.Models;
using JM_Api.Models.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JM_Api.Controllers
{
    public class TransaccionesController : ApiController
    {

        // GET: api/Transacciones/idUsuario=value1
        public List<Transaccion> GetListaPedidosRealizados(int idUsuario)
        {
            var repo = new TransaccionesRepository();
            List<Transaccion> pedidos = repo.RetrievePedidosRealizados(idUsuario);
            return pedidos;
        }

        // POST: api/Transacciones/idPedido=value1&idDirEnvio=value2&idInfoPago=value3&notasEntrega=value4
        public void Post(int idPedido, int idDirEnvio, int idInfoPago, string notasEntrega)
        {
            var repo = new TransaccionesRepository();
            repo.RealizarPedido(idPedido, idDirEnvio, idInfoPago, notasEntrega);
        }
    }
}
