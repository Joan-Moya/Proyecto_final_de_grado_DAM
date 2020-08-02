using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class Transaccion
    {
        public int TransaccionId { get; set; }
        public double Total { get; set; }
        public string NotasEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool PagoRealizado { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int InformacionPagoId { get; set; }
        public int PedidoId { get; set; }
        public int DireccionEnvioId { get; set; }

        public Transaccion()
        {
        }

        public Transaccion(int transaccionId, double total, string notasEntrega, DateTime fechaEntrega, bool pagoRealizado, string estado, DateTime fechaCreacion, int informacionPagoId, int pedidoId, int direccionEnvioId)
        {
            TransaccionId = transaccionId;
            Total = total;
            NotasEntrega = notasEntrega;
            FechaEntrega = fechaEntrega;
            PagoRealizado = pagoRealizado;
            Estado = estado;
            FechaCreacion = fechaCreacion;
            InformacionPagoId = informacionPagoId;
            PedidoId = pedidoId;
            DireccionEnvioId = direccionEnvioId;
        }
    }
}
