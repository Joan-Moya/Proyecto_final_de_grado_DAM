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
    public class UsuariosController : ApiController
    {

        // GET: api/Usuarios/email=valor1&pass=valor2
        public bool GetLoginCheck(string email, string pass)
        {
            bool Accept = false;
            var repo = new UsuariosRepository();
            List<Usuario> UsList = repo.Retrieve();
            foreach (Usuario us in UsList)
            {
                if (us.Email == email && us.Password == pass)
                {
                    Accept = true;
                    break;
                }
            }
            return Accept;
        }

        // GET: api/Usuarios/email=valor1
        public int GetUserId(string email)
        {
            int id = -1;
            var repo = new UsuariosRepository();
            List<Usuario> UsList = repo.Retrieve();
            foreach (Usuario us in UsList)
            {
                if (us.Email == email)
                {
                    id = us.UsuarioId;
                    break;
                }
            }
            return id;
        }

        // POST: api/Usuarios
        public void Post([FromBody]Usuario us)
        {
            var repo = new UsuariosRepository();
            repo.Save(us);
        }

    }
}
