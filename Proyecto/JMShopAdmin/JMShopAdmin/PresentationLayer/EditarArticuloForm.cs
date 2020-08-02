using JMShopAdmin.BusinessLayer;
using JMShopAdmin.DataAccessLayer;
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
    public partial class EditarArticuloForm : Form
    {
        public int productID;
        private Producto antiguoProducto = new Producto();
        private Producto _nuevoProducto = new Producto();
        public bool editado;

        public Producto NuevoProducto
        {
            get
            {
                return _nuevoProducto;
            }
        }

        public EditarArticuloForm(int id)
        {
            editado = false;
            productID = id;

            setAntiguoProducto();
            InitializeComponent();
            textBoxMarca.Text = antiguoProducto.Marca;
            textBoxModelo.Text = antiguoProducto.Modelo;
            textBoxDescripcion.Text = antiguoProducto.Descripcion;
            textBoxPrecio.Text = antiguoProducto.Precio.ToString();
            textBoxTipoCorrea.Text = antiguoProducto.TipoCorrea;
            textBoxCristal.Text = antiguoProducto.Cristal;
            textBoxDiametro.Text = antiguoProducto.Diametro;
            textBoxNombreArchivo.Text = antiguoProducto.ImagenProducto;
        }

        /// <summary>
        /// Busca el objeto producto con la Id de producto de entrada al form y lo guarda en la variable antiguo producto
        /// </summary>
        private void setAntiguoProducto()
        {
            foreach(Producto p in MemoryObjectsDAO.GetListaProductos())
            {
                if(p.Id == productID)
                {
                    antiguoProducto.Id = p.Id;
                    antiguoProducto.Marca = p.Marca;
                    antiguoProducto.Descripcion = p.Descripcion;
                    antiguoProducto.Precio = p.Precio;
                    antiguoProducto.Modelo = p.Modelo;
                    antiguoProducto.TipoCorrea = p.TipoCorrea;
                    antiguoProducto.ImagenProducto = p.ImagenProducto;
                    antiguoProducto.Cristal = p.Cristal;
                    antiguoProducto.Diametro = p.Diametro;
                }
            }
        }
        

        /// <summary>
        /// Copia el estado actual de los campos en la variable nuevoproducto, en el caso de que nuevo producto y viejo producto sean distintos,
        /// cambia la variable editado a true, para que se guarden los cambios al volver al Form de artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            bool result = this.ValidateChildren();
            if (result)
            {
                _nuevoProducto.Id = productID;
                _nuevoProducto.Marca = textBoxMarca.Text;
                _nuevoProducto.Descripcion = textBoxDescripcion.Text;
                _nuevoProducto.Precio = Convert.ToDouble(textBoxPrecio.Text);
                _nuevoProducto.Modelo = textBoxModelo.Text;
                _nuevoProducto.TipoCorrea = textBoxTipoCorrea.Text;
                _nuevoProducto.ImagenProducto = textBoxNombreArchivo.Text;
                _nuevoProducto.Cristal = textBoxCristal.Text;
                _nuevoProducto.Diametro = textBoxDiametro.Text;
                if (!_nuevoProducto.Equals(antiguoProducto))
                {
                    editado = true;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Se tienen que rellenar todos los campos y el precio debe de ser un número", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMarca.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxMarca, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxMarca, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxModelo_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxModelo.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxModelo, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxModelo, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCristal_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCristal.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxCristal, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxCristal, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTipoCorrea_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTipoCorrea.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxTipoCorrea, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxTipoCorrea, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDiametro_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDiametro.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxDiametro, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxDiametro, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNombreArchivo_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNombreArchivo.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxNombreArchivo, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxNombreArchivo, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacinoes para que se introduzca algún valor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDescripcion.Text != "")
            {
                errorProviderEditarArticulo.SetError(textBoxDescripcion, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxDescripcion, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validaciones para que se introduzca algún valor y sea de tipo double.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPrecio_Validating(object sender, CancelEventArgs e)
        {
            double number;
            if (Double.TryParse(textBoxPrecio.Text, out number))
            {
                errorProviderEditarArticulo.SetError(textBoxPrecio, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderEditarArticulo.SetError(textBoxPrecio, "Tienes que introducir un entero o decimal que represente el precio.");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el form sin realizar cambios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
