using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class InformacionPago
    {
        public int InformacionPagoId { get; set; }
        public string NumTarjeta { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int CodSeguridad { get; set; }

        public int UsuarioId { get; set; }

        public InformacionPago()
        {
        }

        public InformacionPago(int informacionPagoId, string numTarjeta, string tipo, DateTime fechaCaducidad, int codSeguridad, int usuarioId)
        {
            InformacionPagoId = informacionPagoId;
            NumTarjeta = numTarjeta;
            Tipo = tipo;
            FechaCaducidad = fechaCaducidad;
            CodSeguridad = codSeguridad;
            UsuarioId = usuarioId;
        }
    }
}
