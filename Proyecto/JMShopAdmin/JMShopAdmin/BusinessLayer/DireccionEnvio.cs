using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class DireccionEnvio
    {
        public int DireccionEnvioId { get; set; }
        public string Calle { get; set; }
        public string NumDomicilio { get; set; }
        public string Poblacion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodPostal { get; set; }

        public int UsuarioId { get; set; }

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
    }
}
