using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class Administrador
    {
        public Administrador(int administradorId, string nombreUsuario, string password, string email)
        {
            AdministradorId = administradorId;
            NombreUsuario = nombreUsuario;
            Password = password;
            Email = email;
        }

        public int AdministradorId { get; set; }
        [MaxLength(20)]
        public string NombreUsuario { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
    }
}