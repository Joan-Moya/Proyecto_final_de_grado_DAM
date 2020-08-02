using JM_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace JM_Api.Controllers
{
    public class ProductosController : ApiController
    {
        // GET: api/Productos
        public List<Producto> Get()
        {
            var repo = new ProductosRepository();
            List<Producto> prod = repo.Retrieve();
            return prod;
        }

        // GET: api/Productos/marca=valor
        public int GetAmountArticles(string marca)
        {
            int cont = 0;
            var repo = new ProductosRepository();
            List<Producto> products = repo.Retrieve();
            foreach(Producto p in products)
            {
                if(p.Marca == marca)
                {
                    cont += 1;
                }
            }
            return cont;
        }

        // GET: api/Productos/mc=valor
        public List<Producto> GetArticles(string mc)
        {
            var repo = new ProductosRepository();
            List<Producto> products = repo.RetrieveByMark(mc);
            return products;
        }
    }
}
