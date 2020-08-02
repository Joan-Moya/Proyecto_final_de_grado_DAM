using CrystalDecisions.CrystalReports.Engine;
using JMShopAdmin.DataAccessLayer;
using JMShopAdmin.Reports;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            LoadAllInformation();
        }

        /// <summary>
        /// Llama a todos los métodos para guardar todos los registros de todas la entidades en memoria.
        /// </summary>
        private void LoadAllInformation()
        {
            DireccionEnvioDAO.GetAll();
            InformacionPagoDAO.GetAll();
            PedidoDAO.GetAll();
            ProductoDAO.GetAll();
            ProductoPedidoDAO.GetAll();
            TransaccionDAO.GetAll();
            UsuarioDAO.GetAll();
        }
        /// <summary>
        /// Botón de navegación a la sección artículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArticulos_Click(object sender, EventArgs e)
        {
            ArticulosForm newForm = new ArticulosForm();
            newForm.ShowDialog(this);
        }
        /// <summary>
        /// Botón de navigación a la sección de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestPedidos_Click(object sender, EventArgs e)
        {
            PedidosForm newForm = new PedidosForm();
            newForm.ShowDialog(this);
        }
        /// <summary>
        /// Botón de navegación a la sección de reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ReportForm newForm = new ReportForm();
            newForm.ShowDialog(this);
        }
        /// <summary>
        /// Botón para salir del menú principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Método que se activa al salir del menú principal, el cual desconectará de la base de datos y limpiara toda la memoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccessLayer.Database.Disconnect();
            MemoryObjectsDAO.ClearDireccionesEnvioList();
            MemoryObjectsDAO.ClearInformacionPagosList();
            MemoryObjectsDAO.ClearPedidosList();
            MemoryObjectsDAO.ClearProductosList();
            MemoryObjectsDAO.ClearProductosPedidosList();
            MemoryObjectsDAO.ClearTransaccionesList();
            MemoryObjectsDAO.ClearUsuariosList();
        }
    }
}
