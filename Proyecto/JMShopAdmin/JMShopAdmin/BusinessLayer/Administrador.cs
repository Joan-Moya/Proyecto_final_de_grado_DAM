using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class Administrador
    {
        public int AdministradorId { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Administrador()
        {
        }

        public Administrador(int administradorId, string nombreUsuario, string password, string email)
        {
            AdministradorId = administradorId;
            NombreUsuario = nombreUsuario;
            Password = password;
            Email = email;
        }
    }
}
