using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Usuario()
        {
        }

        public Usuario(int usuarioId, string nombre, string apellidos, string email, string password, string telefono, DateTime fechaNacimiento)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Password = password;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
        }

        
    }
}
