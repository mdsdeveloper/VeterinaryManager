using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeterinaryManagerGenNHibernate.CAD.VeterinaryManager;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;

namespace Presentacion
{
    public partial class EditarCliente : Form
    {
        String dia;
        public EditarCliente()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesCAD clienteCAD = new ClientesCAD();

            if (tbDni.Text != "")
            {
                if (clienteCAD.ReadOID(tbDni.Text) != null)
                {
                    dia = clienteCAD.ReadOID(tbDni.Text).Fecha;
                    tbApellidos.Text = clienteCAD.ReadOID(tbDni.Text).Apellido;
                    tbNombre.Text = clienteCAD.ReadOID(tbDni.Text).Nombre;
                    tbDireccion.Text = clienteCAD.ReadOID(tbDni.Text).Direccion;
                    tbEmail.Text = clienteCAD.ReadOID(tbDni.Text).Email;
                    tbTelefono.Text = clienteCAD.ReadOID(tbDni.Text).Telefono;
                    tbFecha.Text = dia.ToString() ;
                    groupBox1.Visible = true;
                    tbDni.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                }
                
            }
            else 
            {
                MessageBox.Show("Tienes que introducir un DNI");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientesCEN clienteCEN = null;
            
            if (tbNombre.Text != "" && tbApellidos.Text != "" && tbEmail.Text != "" && tbTelefono.Text != "" && tbDireccion.Text != "" && tbFecha.Text != "")
            {
                
                clienteCEN = new ClientesCEN();
                clienteCEN.Modify(tbDni.Text, tbNombre.Text, tbApellidos.Text, tbEmail.Text, tbTelefono.Text, tbDireccion.Text, dia);
                MessageBox.Show("Modificación correcta");
                Limpiar();
                tbDni.Enabled = true;
                groupBox1.Visible = false;
                
                

                            
                //this.Dispose(false);
            }
            else
            {
                MessageBox.Show("Falta rellenar algún dato");
            }
        }
        public void Limpiar()
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbEmail.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            tbDni.Text = "";
            tbFecha.Text = "";
        }
    }
}
