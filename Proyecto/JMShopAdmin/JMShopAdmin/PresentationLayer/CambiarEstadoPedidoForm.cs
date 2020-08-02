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
    public partial class CambiarEstadoPedidoForm : Form
    {
        private string antiguoEstado;
        private string _nuevoEstado { get; set; }
        public bool cambiado;

        public string NuevoEstado
        {
            get
            {
                return _nuevoEstado;
            }
        }

        public CambiarEstadoPedidoForm(string estado)
        {
            cambiado = false;
            antiguoEstado = estado;
            _nuevoEstado = "";
            InitializeComponent();
            checkInitialStatus();
        }
        /// <summary>
        /// Checkea el radio button inicial en función del estado del pedido al entrar al form.
        /// </summary>
        private void checkInitialStatus()
        {
            if(antiguoEstado == "Pendiente de pago")
            {
                radioButtonPendientePago.Checked = true;
            }else if(antiguoEstado == "Preparando pedido")
            {
                radioButtonPreparandoPedido.Checked = true;
            }else if(antiguoEstado == "Enviado")
            {
                radioButtonEnviado.Checked = true;
            }else if(antiguoEstado == "Entregado")
            {
                radioButtonEntregado.Checked = true;
            }
        }
        /// <summary>
        /// Fija el estado del pedido en función del radio button seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButtonPendientePago.Checked)
            {
                _nuevoEstado = "Pendiente de pago";
            }else if (radioButtonPreparandoPedido.Checked)
            {
                _nuevoEstado = "Preparando pedido";
            }else if (radioButtonEnviado.Checked)
            {
                _nuevoEstado = "Enviado";
            }else if (radioButtonEntregado.Checked)
            {
                _nuevoEstado = "Entregado";
            }
            if(_nuevoEstado != antiguoEstado)
            {
                cambiado = true;
            }
            this.Close();
        }
        /// <summary>
        /// Cierra el formularo sin realizar cambios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
