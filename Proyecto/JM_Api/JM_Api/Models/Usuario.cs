using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class Usuario
    {
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

        public Usuario()
        {
        }

        public int UsuarioId { get; set; }
        [MaxLength(20)]
        public string Nombre { get; set; }
        [MaxLength(30)]
        public string Apellidos { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(12)]
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public List<InformacionPago> InformacionPagos { get; set; }
        public List<DireccionEnvio> DireccionesEnvio { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}