using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class DireccionEnvio
    {
        public DireccionEnvio()
        {
        }

        public DireccionEnvio(int direccionEnvioId, string calle, string numDomicilio, string poblacion, string ciudad, string provincia, string codPostal, int usuarioId)
        {
            DireccionEnvioId = direccionEnvioId;
            Calle = calle;
            NumDomicilio = numDomicilio;
            Poblacion = poblacion;
            Ciudad = ciudad;
            Provincia = provincia;
            CodPostal = codPostal;
            UsuarioId = usuarioId;
        }

        public int DireccionEnvioId { get; set; }
        [MaxLength(50)]
        public string Calle { get; set; }
        [MaxLength(30)]
        public string NumDomicilio { get; set; }
        [MaxLength(20)]
        public string Poblacion { get; set; }
        [MaxLength(20)]
        public string Ciudad { get; set; }
        [MaxLength(20)]
        public string Provincia { get; set; }
        [MaxLength(10)]
        public string CodPostal { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Transaccion> Transacciones { get; set; }
    }
}