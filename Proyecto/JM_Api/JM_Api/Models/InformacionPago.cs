using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class InformacionPago
    {
        public InformacionPago(int informacionPagoId, string numTarjeta, string tipo, DateTime fechaCaducidad, int codSeguridad, int usuarioId)
        {
            InformacionPagoId = informacionPagoId;
            NumTarjeta = numTarjeta;
            Tipo = tipo;
            FechaCaducidad = fechaCaducidad;
            CodSeguridad = codSeguridad;
            UsuarioId = usuarioId;
        }

        public InformacionPago()
        {
        }

        public int InformacionPagoId { get; set; }
        [MaxLength(20)]
        public string NumTarjeta { get; set; }
        [MaxLength(20)]
        public string Tipo { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int CodSeguridad { get; set; }

        public List<Transaccion> Transacciones { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}