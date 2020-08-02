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
    public class DireccionesEnvioController : ApiController
    {

        // GET: api/DireccionesEnvio/userid=value1
        public List<DireccionEnvio> GetUserDirecciones(int userId)
        {
            List<DireccionEnvio> userDirec = new List<DireccionEnvio>();
            var repo = new DireccionesEnvioRepository();
            userDirec = repo.RetrieveByUser(userId);
            return userDirec;
        }

        // GET: api/DireccionesEnvio/pedidoId=value1
        public DireccionEnvio GetDireccionPedido(int pedidoId)
        {
            DireccionEnvio pedDirec = new DireccionEnvio();
            var repo = new DireccionesEnvioRepository();
            pedDirec = repo.RetrieveDireccionPedido(pedidoId);
            return pedDirec;
        }

        // POST: api/DireccionesEnvio
        public void Post([FromBody]DireccionEnvio dir)
        {
            var repo = new DireccionesEnvioRepository();
            repo.Save(dir);
        }

        // DELETE: api/DireccionesEnvio/dirId=value1
        public void Delete(int dirId)
        {
            var repo = new DireccionesEnvioRepository();
            repo.Delete(dirId);
        }
    }
}
