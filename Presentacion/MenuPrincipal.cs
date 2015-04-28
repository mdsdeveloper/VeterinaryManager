using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertarClientes insertarCliente = new InsertarClientes();
            insertarCliente.Visible = true;
          //  this.Dispose(false);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente editar = new EditarCliente();
            editar.Visible = true;
        }
    }
}
