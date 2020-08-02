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
    public partial class BorrarArticuloForm : Form
    {
        public bool eliminar;
        public int idProducto;

        public BorrarArticuloForm(int id)
        {
            eliminar = false;
            idProducto = id;
            InitializeComponent();
            labelNombreArticulo.Text = MemoryObjectsDAO.GetProductoModelById(idProducto);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
