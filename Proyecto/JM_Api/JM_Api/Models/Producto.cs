using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JM_Api.Models
{
    public class Producto
    {
        public Producto(int id, string modelo, string marca, string tipoCorrea, string imagenProducto, string cristal, string diametro, string descripcion, double precio, List<ProductoPedido> productosPedidos)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            TipoCorrea = tipoCorrea;
            Cristal = cristal;
            Diametro = diametro;
            ImagenProducto = imagenProducto;
            Descripcion = descripcion;
            Precio = precio;
            ProductosPedidos = productosPedidos;
        }

        public Producto()
        {
        }

        public int Id { get; set; }
        [MaxLength(30)]
        public string Modelo { get; set; }
        [MaxLength(20)]
        public string Marca { get; set; }
        [MaxLength(20)]
        public string TipoCorrea { get; set; }
        [MaxLength(20)]
        public string Cristal { get; set; }
        [MaxLength(100)]
        public string ImagenProducto { get; set; }
        [MaxLength(20)]
        public string Diametro { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public List<ProductoPedido> ProductosPedidos { get; set; }
        
    }

   
}