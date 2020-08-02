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
    public partial class PedidosForm : Form
    {
        public PedidosForm()
        {
            InitializeComponent();
            PopulatePedidos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Rellena el dataGrid con los pedidos
        /// </summary>
        private void PopulatePedidos()
        {
            dataGridViewPedidos.Rows.Clear();
            foreach (Pedido p in MemoryObjectsDAO.GetListaPedidos())
            {
                dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
            }
        }
        /// <summary>
        /// Botón para filtrar los pedidos en función de su estado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            dataGridViewPedidos.Rows.Clear();
            if (radioButtonTodos.Checked)
            {
                PopulatePedidos();
            }else if (radioButtonEntregados.Checked)
            {
                foreach (Pedido p in MemoryObjectsDAO.GetListaPedidos())
                {
                    if(MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId) == "Entregado")
                    {
                        dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
                    }
                }
            }else if (radioButtonPendientes.Checked)
            {
                foreach (Pedido p in MemoryObjectsDAO.GetListaPedidos())
                {
                    if (checkBoxPendientePago.Checked && MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId) == "Pendiente de pago")
                    { 
                        dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
                    }else if(checkBoxPreparando.Checked && MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId) == "Preparando pedido")
                    {
                        dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
                    }else if(checkBoxEnviado.Checked && MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId) == "Enviado")
                    {
                        dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
                    }
                }
            }
        }
        /// <summary>
        /// Navega a la pantalla de seleccionar el estado de pedido a cambiar y guarda los cambios en caso de darle a guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCambiarEstadoPedido_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.Rows.Count > 1)
            {
                int idPedido = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;
                string estado = MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(idPedido);
                CambiarEstadoPedidoForm newForm = new CambiarEstadoPedidoForm(estado);
                newForm.ShowDialog(this);
                if (newForm.cambiado)
                {
                    int idTransaccion = MemoryObjectsDAO.getTransaccionIdByPedidoId(idPedido);
                    bool consultaRealizada = TransaccionDAO.EditTransaccion(idTransaccion, newForm.NuevoEstado);
                    
                    if (consultaRealizada)
                    {
                        MemoryObjectsDAO.ClearTransaccionesList();
                        TransaccionDAO.GetAll();
                    }
                    PopulatePedidos();
                }
            }
        }
        /// <summary>
        /// Navega a la pantalla de mostrar detalles del pedido seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDetallesPedido_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.Rows.Count > 0)
            {
                int id = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;
                DetallePedidoForm newForm = new DetallePedidoForm(id);
                newForm.ShowDialog(this);
            }
        }
        /// <summary>
        /// Filtra los pedidos por email de cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrarCliente_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPedidos.Rows.Clear();
            if (textBoxFiltrarCliente.Text == "")
            {
                PopulatePedidos();
            }
            else
            {
                foreach (Pedido p in MemoryObjectsDAO.GetListaPedidos())
                {
                    if (MemoryObjectsDAO.GetUserEmailById(p.UsuarioId).Contains(textBoxFiltrarCliente.Text))
                    {
                        dataGridViewPedidos.Rows.Add(p.PedidoId, MemoryObjectsDAO.GetUserEmailById(p.UsuarioId), MemoryObjectsDAO.GetEstadoTransaccionByIdPedido(p.PedidoId), MemoryObjectsDAO.GetTotalTransaccionByIdPedido(p.PedidoId));
                    } 
                }
            }
        }
    }
}
