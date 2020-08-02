using JMShopAdmin.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMShopAdmin.PresentationLayer
{
    public partial class DescripcionArticuloForm : Form
    {
        public DescripcionArticuloForm(Producto producto)
        {
            InitializeComponent();
            textBoxDescripcion.Text = producto.Descripcion;
            labelMarca.Text = producto.Marca;
            labelModelo.Text = producto.Modelo;
            labelDiametro.Text = producto.Diametro;
            labelCristal.Text = producto.Cristal;
            labelTipoCorrea.Text = producto.TipoCorrea;
            labelPrecio.Text = Convert.ToString(producto.Precio);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
