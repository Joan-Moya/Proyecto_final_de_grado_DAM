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
    public partial class DetallePedidoForm : Form
    {
        private int idPedido;
        private int idUsuario;
        private int idDireccionEnvio;

        public DetallePedidoForm(int id)
        {
            idPedido = id;
            idUsuario = -1;
            idDireccionEnvio = -1;
            InitializeComponent();
            getIds();
            PopulateAll();
        }
        /// <summary>
        /// Obtiene la id de usuario y de direccion de envio a través de la id de pedido.
        /// </summary>
        private void getIds()
        {
            foreach (Pedido pedido in MemoryObjectsDAO.GetListaPedidos())
            {
                if (pedido.PedidoId == idPedido)
                {
                    idUsuario = pedido.UsuarioId;
                }
            }

            foreach(Transaccion transaccion in MemoryObjectsDAO.GetListaTransacciones())
            {
                if(transaccion.PedidoId == idPedido)
                {
                    idDireccionEnvio = transaccion.DireccionEnvioId;
                }
            }
        }
        /// <summary>
        /// Rellena todos los campos usando la id de usuario, id pedido y id de direcciones de envio.
        /// </summary>
        private void PopulateAll()
        {
            foreach (Usuario usuario in MemoryObjectsDAO.GetListaUsuarios())
            {
                if(usuario.UsuarioId == idUsuario)
                {
                    textBoxNombre.Text = usuario.Nombre;
                    textBoxApellidos.Text = usuario.Apellidos;
                    textBoxEmail.Text = usuario.Email;
                    textBoxTelefono.Text = usuario.Telefono;
                }
            }

            foreach (DireccionEnvio direccion in MemoryObjectsDAO.GetListaListaDireccionesEnvio())
            {
                if (direccion.DireccionEnvioId == idDireccionEnvio)
                {
                    textBoxDireccion.Text = direccion.Calle;
                    textBoxNumero.Text = direccion.NumDomicilio;
                    textBoxCodPostal.Text = direccion.CodPostal;
                    textBoxProvincia.Text = direccion.Provincia;
                    textBoxPoblacion.Text = direccion.Poblacion;
                }
            }

            dataGridViewProductos.Rows.Clear();
            foreach (ProductoPedido pp in MemoryObjectsDAO.GetListaProductosPedidos())
            {
                if(pp.PedidoId == idPedido)
                {
                    dataGridViewProductos.Rows.Add(MemoryObjectsDAO.GetProductoMarcaById(pp.ProductoId), MemoryObjectsDAO.GetProductoModelById(pp.ProductoId), pp.Cantidad, MemoryObjectsDAO.GetProductoPrecioById(pp.ProductoId), pp.Total);
                }
            }

            textBoxTotal.Text = Convert.ToString(MemoryObjectsDAO.GetTotalTransaccionByIdPedido(idPedido));
        }

        /// <summary>
        /// Botón para cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
