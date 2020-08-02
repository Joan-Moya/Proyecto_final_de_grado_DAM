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
    public class InformacionPagoController : ApiController
    {

        // GET: api/InformacionPagos/userId=value1
        public List<InformacionPago> GetUserDirecciones(int userId)
        {
            List<InformacionPago> userDirec = new List<InformacionPago>();
            var repo = new InformacionesPagoRepositoy();
            userDirec = repo.RetrieveByUser(userId);
            return userDirec;
        }

        // GET: api/InformacionPagos/pedidoId=value1
        public InformacionPago GetInfoPagoPedido(int pedidoId)
        {
            InformacionPago infoPago = new InformacionPago();
            var repo = new InformacionesPagoRepositoy();
            infoPago = repo.RetrieveInfoPagoPedido(pedidoId);
            return infoPago;
        }

        // POST: api/InformacionPagos
        public void Post([FromBody]InformacionPago infopago)
        {
            var repo = new InformacionesPagoRepositoy();
            repo.Save(infopago);
        }


        // DELETE: api/InformacionPagos/InfId=value1
        public void Delete(int InfId)
        {
            var repo = new InformacionesPagoRepositoy();
            repo.Delete(InfId);
        }
    }
}
