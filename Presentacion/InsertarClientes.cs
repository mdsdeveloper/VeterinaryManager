using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;

namespace Presentacion
{
    public partial class InsertarClientes : Form
    {
        public InsertarClientes()
        {
            InitializeComponent();
            Limpiar();
            tbFecha.Text = DateTime.Today.Day.ToString()+"/"+DateTime.Today.Month.ToString()+"/"+DateTime.Today.Year.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" && tbApellidos.Text != "" && tbSexo.Text != "" && tbTelefono.Text != "" && tbDireccion.Text != "" && tbDni.Text != "" && tbFecha.Text != "")
            {
                ClientesCEN cliente = new ClientesCEN();
                cliente.Nuevo_cliente(tbNombre.Text, tbApellidos.Text, tbSexo.Text, tbTelefono.Text, tbDireccion.Text, tbDni.Text, DateTime.Today);
                MessageBox.Show("Cliente insertado correctamente");
                this.Dispose(false);
            }
            else
            {
                MessageBox.Show("Tienes que rellenar todos los datos");
            }
        }
        public void Limpiar()
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbSexo.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            tbDni.Text = "";
            tbFecha.Text = "";
        }
    }
}
