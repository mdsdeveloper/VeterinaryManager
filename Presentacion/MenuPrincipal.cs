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

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificarCliente cliente = new ModificarCliente();
            cliente.Visible = true;
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cierro la ventana y la aplicación.
            this.Close();
            Application.Exit();
        }

        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BorrarCliente borrar = new BorrarCliente();
            borrar.Visible = true;
        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Animales animal = new Animales();
            animal.Visible = true;
        }

        private void tratamientoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Tratamientos tratamiento = new Tratamientos();
            tratamiento.Visible = true;
        }

        private void servicioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Servicios servicio = new Servicios();
            servicio.Visible = true;
        }

         
    }
}
