using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.BusinessLayer
{
    public class Producto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string TipoCorrea { get; set; }
        public string Cristal { get; set; }
        public string ImagenProducto { get; set; }
        public string Diametro { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }



        public Producto(Producto p)
        {
            Id = p.Id;
            Modelo = p.Modelo;
            Marca = p.Marca;
            TipoCorrea = p.TipoCorrea;
            Cristal = p.Cristal;
            ImagenProducto = p.ImagenProducto;
            Diametro = p.Diametro;
            Descripcion = p.Descripcion;
            Precio = p.Precio;
        }

        public Producto()
        {
            Id = -1;
            Modelo = "Vacio";
            Marca = "Vacio";
            TipoCorrea = "Vacio";
            Cristal = "Vacio";
            ImagenProducto = "Vacio";
            Diametro = "Vacio";
            Descripcion = "Vacio";
            Precio = -1;
        }

        public Producto(int id, string modelo, string marca, string tipoCorrea, string cristal, string imagenProducto, string diametro, string descripcion, double precio)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            TipoCorrea = tipoCorrea;
            Cristal = cristal;
            ImagenProducto = imagenProducto;
            Diametro = diametro;
            Descripcion = descripcion;
            Precio = precio;
        }

    }
}
