namespace JMShopAdmin.Reports
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewerJM = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStripReportes = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosSuperioresAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosSuperioresaXReport1 = new JMShopAdmin.Reports.PedidosSuperioresaXReport();
            this.PedidosSuperioresaXReport2 = new JMShopAdmin.Reports.PedidosSuperioresaXReport();
            this.PedidosSuperioresaXReport3 = new JMShopAdmin.Reports.PedidosSuperioresaXReport();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewerJM
            // 
            this.crystalReportViewerJM.ActiveViewIndex = -1;
            this.crystalReportViewerJM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerJM.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerJM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerJM.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewerJM.Name = "crystalReportViewerJM";
            this.crystalReportViewerJM.Size = new System.Drawing.Size(800, 426);
            this.crystalReportViewerJM.TabIndex = 0;
            this.crystalReportViewerJM.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // menuStripReportes
            // 
            this.menuStripReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStripReportes.Location = new System.Drawing.Point(0, 0);
            this.menuStripReportes.Name = "menuStripReportes";
            this.menuStripReportes.Size = new System.Drawing.Size(800, 24);
            this.menuStripReportes.TabIndex = 1;
            this.menuStripReportes.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosSuperioresAXToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // pedidosSuperioresAXToolStripMenuItem
            // 
            this.pedidosSuperioresAXToolStripMenuItem.Name = "pedidosSuperioresAXToolStripMenuItem";
            this.pedidosSuperioresAXToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pedidosSuperioresAXToolStripMenuItem.Text = "Pedidos superiores a X";
            this.pedidosSuperioresAXToolStripMenuItem.Click += new System.EventHandler(this.pedidosSuperioresAXToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // mostrarPedidosDeUnDíaConcretoToolStripMenuItem
            // 
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem.Name = "mostrarPedidosDeUnDíaConcretoToolStripMenuItem";
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem.Text = "Mostrar pedidos de un día concreto";
            this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem.Click += new System.EventHandler(this.mostrarPedidosDeUnDíaConcretoToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerJM);
            this.Controls.Add(this.menuStripReportes);
            this.MainMenuStrip = this.menuStripReportes;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.menuStripReportes.ResumeLayout(false);
            this.menuStripReportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerJM;
        private System.Windows.Forms.MenuStrip menuStripReportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private PedidosSuperioresaXReport PedidosSuperioresaXReport1;
        private System.Windows.Forms.ToolStripMenuItem pedidosSuperioresAXToolStripMenuItem;
        private PedidosSuperioresaXReport PedidosSuperioresaXReport3;
        private PedidosSuperioresaXReport PedidosSuperioresaXReport2;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPedidosDeUnDíaConcretoToolStripMenuItem;
    }
}