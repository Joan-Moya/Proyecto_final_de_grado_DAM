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
    public class ProductosPedidosController : ApiController
    {
        // GET: api/ProductosPedidos/userId=value1
        public List<ProductoPedidoDTO> GetProductosCarrito(int userId)
        {
            var repo = new ProductosPedidosRepository();
            List<ProductoPedidoDTO> productos = repo.ListarProductosCarrito(userId);
            return productos;
        }

        // GET: api/ProductosPedidos/pedidoId=value1
        public List<ProductoPedidoDTO> GetProductosPedido(int pedidoId)
        {
            var repo = new ProductosPedidosRepository();
            List<ProductoPedidoDTO> productos = repo.ListarProductosPedido(pedidoId);
            return productos;
        }

        // POST: api/ProductosPedidos/pedId=value1&usId=value2
        public void AnyadirProductoCarrito(int idProd, int idUser)
        {
            var repo = new ProductosPedidosRepository();
            repo.AnyadirProductoAlCarrito(idProd, idUser);
        }

        // POST: api/ProductosPedidos/ppId=value1
        public void SumarUnidadProductoCarrito(int ppId)
        {
            var repo = new ProductosPedidosRepository();
            repo.SumarUnidadProductoDeCarrito(ppId);
        }

        // POST: api/ProductosPedidos/propeId=value1
        public void RestarUnidadProductoCarrito(int propeId)
        {
            var repo = new ProductosPedidosRepository();
            repo.RestarUnidadProductoDeCarrito(propeId);
        }

    }
}
