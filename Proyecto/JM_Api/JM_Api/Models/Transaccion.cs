using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class Transaccion
    {
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

        public Transaccion()
        {
            
        }

        public int TransaccionId { get; set; }
        public double Total { get; set; }
        [MaxLength(150)]
        public string NotasEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool PagoRealizado { get; set; }
        [MaxLength(25)]
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int InformacionPagoId { get; set; }
        public InformacionPago InformacionPago { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int DireccionEnvioId { get; set; }
        public DireccionEnvio DireccionEnvio { get; set; }
    }
}