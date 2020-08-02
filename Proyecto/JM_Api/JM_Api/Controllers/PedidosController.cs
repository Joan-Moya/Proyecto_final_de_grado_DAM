using JM_Api.Models.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JM_Api.Controllers
{
    public class PedidosController : ApiController
    {
        // DELETE: api/Pedidos/idPedido=value1
        public void Delete(int idPedido)
        {
            var repo = new PedidosRepository();
            repo.Delete(idPedido);
        }
    }
}
