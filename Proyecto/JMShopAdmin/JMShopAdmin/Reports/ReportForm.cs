using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMShopAdmin.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Muestra PedidosSuperioresaXReport.rpt al seleccionar esta opción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidosSuperioresAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");//Se elimina la dirección bin Debug para q pueda encontrar EventsReport.rpt
            // MessageBox.Show(reportPath + "PedidosSuperioresaXReport.rpt");
            ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("PedidosSuperioresaXReport.rpt");  //Esta linea se sustituiría por la de abajo cuando fuesemos a compilar/distribuir la aplicación. 
            cryRpt.Load(reportPath + "Reports\\PedidosSuperioresaXReport.rpt");
            crystalReportViewerJM.ReportSource = cryRpt;
            crystalReportViewerJM.Refresh();
        }
        /// <summary>
        /// Muestra ListarClientesReport.rpt al seleccionar esta opción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");//Se elimina la dirección bin Debug para q pueda encontrar EventsReport.rpt
            // MessageBox.Show(reportPath + "ListarClientesReport.rpt");
            ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("ListarClientesReport.rpt");  //Esta linea se sustituiría por la de abajo cuando fuesemos a compilar/distribuir la aplicación. 
            cryRpt.Load(reportPath + "Reports\\ListarClientesReport.rpt");
            crystalReportViewerJM.ReportSource = cryRpt;
            crystalReportViewerJM.Refresh();
        }
        /// <summary>
        /// Muestra SeleccionarPedidosDeUnaFechaReport.rpt al seleccionar esta opción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarPedidosDeUnDíaConcretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");//Se elimina la dirección bin Debug para q pueda encontrar EventsReport.rpt
            // MessageBox.Show(reportPath + "SeleccionarPedidosDeUnaFechaReport.rpt");
            ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("SeleccionarPedidosDeUnaFechaReport.rpt");  //Esta linea se sustituiría por la de abajo cuando fuesemos a compilar/distribuir la aplicación. 
            cryRpt.Load(reportPath + "Reports\\SeleccionarPedidosDeUnaFechaReport.rpt");
            crystalReportViewerJM.ReportSource = cryRpt;
            crystalReportViewerJM.Refresh();
        }
    }
}
