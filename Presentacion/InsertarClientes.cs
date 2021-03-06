﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;
using VeterinaryManagerGenNHibernate.CAD.VeterinaryManager;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace Presentacion
{
    public partial class InsertarClientes : Form
    {
        public DateTime date = DateTime.Now;
        public InsertarClientes()
        {
            InitializeComponent();
            Limpiar();
            tbFecha.Text = date.ToString();
            tbFecha.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesCAD clienteCAD = new ClientesCAD();
            
            
            if (clienteCAD.ReadOID(tbDni.Text) == null) 
            {
                
                if (tbNombre.Text != "" && tbApellidos.Text != "" && tbEmail.Text != "" && tbTelefono.Text != "" && tbDireccion.Text != "" && tbDni.Text != "" && tbFecha.Text != "")
                {
                    ClientesCEN cliente = new ClientesCEN();
                    cliente.Nuevo_cliente(tbNombre.Text, tbApellidos.Text, tbEmail.Text, tbTelefono.Text, tbDireccion.Text, tbDni.Text, date.ToString());
                    MessageBox.Show("Cliente insertado correctamente");
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show("Tienes que rellenar todos los datos");
                }
            }
            else 
            {
                MessageBox.Show("El cliente ya existe");
                Limpiar();
                tbFecha.Text = date.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
