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
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
            PopulateProductos();
        }
        /// <summary>
        /// Llena el dataGrid con todos los productos
        /// </summary>
        private void PopulateProductos()
        {
            dataGridViewProductos.Rows.Clear();
            foreach (Producto producto in MemoryObjectsDAO.GetListaProductos())
            {
                dataGridViewProductos.Rows.Add(producto.Id, producto.Marca, producto.Modelo, producto.Precio);
            }
        }
        /// <summary>
        /// Devuelve el objeto del producto seleccionado en el dataGrid
        /// </summary>
        /// <returns>Objeto Producto</returns>
        private Producto GetDataGridViewProducto()
        {
            foreach(Producto p in MemoryObjectsDAO.GetListaProductos())
            {
                if(p.Id == (int)dataGridViewProductos.SelectedRows[0].Cells[0].Value)
                {
                    Producto producto = new Producto(p);
                    return producto;
                }
            }
            return null;
        }
        /// <summary>
        /// Navegación a la pantalla de detalles de artículo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDescripccionArtículo_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count > 1)
            {
                if (dataGridViewProductos.Rows.Count > 0)//Si tenemos mas de una fila
                {
                    Producto producto = new Producto(GetDataGridViewProducto());
                    DescripcionArticuloForm newForm = new DescripcionArticuloForm(producto);
                    newForm.ShowDialog(this);
                }
            }
        }
        /// <summary>
        /// Navegación a la pantalla de añadir artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddArticulo_Click(object sender, EventArgs e)
        {
            AnyadirArticuloForm newForm = new AnyadirArticuloForm();
            newForm.ShowDialog(this);
            if (newForm.crear)
            {
                bool consultaRealizada = ProductoDAO.CreateProducto(newForm.NuevoProducto);
                if (consultaRealizada)
                {
                    MemoryObjectsDAO.ClearProductosList();
                    ProductoDAO.GetAll();
                }
                PopulateProductos();
            }
        }

        /// <summary>
        /// Navegación a la pantalla de confirmación de borrado de artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count > 1)
            {
                BorrarArticuloForm newForm = new BorrarArticuloForm((int)dataGridViewProductos.SelectedRows[0].Cells[0].Value);
                newForm.ShowDialog(this);
                if (newForm.eliminar)
                {
                    bool consultaRealizada = ProductoDAO.DeleteProducto(newForm.idProducto);
                    if (consultaRealizada)
                    {
                        MemoryObjectsDAO.DeleteProducto(newForm.idProducto);
                        PopulateProductos();
                    }
                }
            }
        }
        /// <summary>
        /// Navegación a la pantalla de edición de artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarArticulo_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count > 1)
            {
                int id = (int)dataGridViewProductos.SelectedRows[0].Cells[0].Value;
                EditarArticuloForm newForm = new EditarArticuloForm(id);
                newForm.ShowDialog(this);
                if (newForm.editado)
                {
                    ProductoDAO.EditProducto(newForm.NuevoProducto);
                    MemoryObjectsDAO.ClearProductosList();
                    ProductoDAO.GetAll();
                }
                PopulateProductos();
            }
                
        }
        /// <summary>
        /// Cierra el form de articulos volviendo al menú principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVolverMenú_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Método de filtrado cruzado. Si ambas cajas de texto se encuentran vacías muestra todos los artículos cuyo marca y/o modelo cuyo texto contiene los valores introducidos.
        /// Si una está vacía y la otra no, filtra solo teniendo en cuenta la que no está vacía.
        /// Si ninguna de las dos están vacías, filtra teniendo en cuenta tanto la marca como el modelo.
        /// </summary>
        private void Filtrar()
        {
            dataGridViewProductos.Rows.Clear();
            if (textBoxFiltrarMarca.Text == "" && textBoxFiltrarModelo.Text == "")
            {
                foreach (Producto producto in MemoryObjectsDAO.GetListaProductos())
                {
                    dataGridViewProductos.Rows.Add(producto.Id, producto.Marca, producto.Modelo, producto.Precio);
                }
            }
            else if(textBoxFiltrarMarca.Text != "" && textBoxFiltrarModelo.Text == "")
            {
                foreach (Producto producto in MemoryObjectsDAO.GetListaProductos())
                {
                    if (producto.Marca.Contains(textBoxFiltrarMarca.Text))
                    {
                        dataGridViewProductos.Rows.Add(producto.Id, producto.Marca, producto.Modelo, producto.Precio);
                    }
                }
            }
            else if(textBoxFiltrarMarca.Text == "" && textBoxFiltrarModelo.Text != "")
            {
                foreach (Producto producto in MemoryObjectsDAO.GetListaProductos())
                {
                    if (producto.Modelo.Contains(textBoxFiltrarModelo.Text))
                    {
                        dataGridViewProductos.Rows.Add(producto.Id, producto.Marca, producto.Modelo, producto.Precio);
                    }
                }
            }
            else if(textBoxFiltrarMarca.Text != "" && textBoxFiltrarModelo.Text != "")
            {
                foreach (Producto producto in MemoryObjectsDAO.GetListaProductos())
                {
                    if (producto.Modelo.Contains(textBoxFiltrarModelo.Text) && producto.Marca.Contains(textBoxFiltrarMarca.Text))
                    {
                        dataGridViewProductos.Rows.Add(producto.Id, producto.Marca, producto.Modelo, producto.Precio);
                    }
                }
            }
        }
        /// <summary>
        /// Activa el filtrado al cambiar el texto de la caja de texto Marca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrarMarca_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        /// <summary>
        /// Activa el filtrado al cambiar el texto de la caja de texto Marca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrarModelo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
