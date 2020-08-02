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
    public partial class AnyadirArticuloForm : Form
    {
        private Producto _nuevoProducto { get; set; }
        public bool crear;

        public Producto NuevoProducto
        {
            get
            {
                return _nuevoProducto;
            }
        }

        public AnyadirArticuloForm()
        {
            _nuevoProducto = new Producto();
            crear = false;
            InitializeComponent();
        }
        /// <summary>
        /// Salir sin añadir un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sale del form, fijando la variable crear en true, para que guarde el artículo en la base de datos y en la memoria al volver a articulosForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            bool result = this.ValidateChildren();
            if (result)
            {
                _nuevoProducto.Marca = textBoxMarca.Text;
                _nuevoProducto.Modelo = textBoxModelo.Text;
                _nuevoProducto.Cristal = textBoxCristal.Text;
                _nuevoProducto.Diametro = textBoxDiametro.Text;
                _nuevoProducto.TipoCorrea = textBoxTipoCorrea.Text;
                _nuevoProducto.ImagenProducto = textBoxNombreArchivo.Text;
                _nuevoProducto.Precio = Convert.ToDouble(textBoxPrecio.Text);
                _nuevoProducto.Descripcion = textBoxDescripcion.Text;
                crear = true;
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
                errorProviderAddProducto.SetError(textBoxMarca, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxMarca, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxModelo, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxModelo, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxCristal, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxCristal, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxTipoCorrea, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxTipoCorrea, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxDiametro, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxDiametro, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxNombreArchivo, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxNombreArchivo, "Tienes que introducir algun valor.");
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
                errorProviderAddProducto.SetError(textBoxDescripcion, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxDescripcion, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validaciones para que se introduzca algún valor y sea de tipo double
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPrecio_Validating(object sender, CancelEventArgs e)
        {
            double number;
            if (Double.TryParse(textBoxPrecio.Text, out number))
            {
                errorProviderAddProducto.SetError(textBoxPrecio, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderAddProducto.SetError(textBoxPrecio, "Tienes que introducir un entero o decimal que represente el precio.");
                e.Cancel = true;
            }
        }
    }
}
