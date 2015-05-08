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
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace Presentacion
{
    public partial class EditarCliente : Form
    {
        String dia;
        public EditarCliente()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  ClientesCAD clienteCAD = new ClientesCAD();

            
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
                }*/
            ClientesCAD clienteCAD = new ClientesCAD();

            int i;
            i = dataGridView1.CurrentCell.RowIndex;

            if (clienteCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()) != null)
            {
                dia = clienteCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()).Fecha;
                tbApellidos.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                tbNombre.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                tbDireccion.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                tbEmail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                tbTelefono.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                tbFecha.Text = dia.ToString();
                groupBox1.Visible = true;
                tbDni.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                tbDni.Enabled = false;
            }
            else
            {
                MessageBox.Show("El cliente no existe");
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
                this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet.Clientes);
                tbDni.Enabled = true;
                
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

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet.Clientes);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClientesCEN cliente = null;
            ClientesEN clienteEN = null;
            if (tbDni1.Text != null)
         /*   {
                cliente = new ClientesCEN();
                clienteEN = new ClientesEN();
                clienteEN = cliente.ReadOID(tbDni1.Text);
                tbNombre.Text = clienteEN.Nombre;
                tbApellidos.Text = clienteEN.Apellido;
                tbDni.Text = clienteEN.Dni;
                tbEmail.Text = clienteEN.Email;
                tbTelefono.Text = clienteEN.Telefono;
                tbDireccion.Text = clienteEN.Direccion;
                tbFecha.Text = clienteEN.Fecha;

            }*/
            if (tbNombre1.Text != null)
            {
                cliente = new ClientesCEN();
                IList<ClientesEN> listaClientes = new List<ClientesEN>();
                String[] listaDatos = listaDatos = new String[7];

                listaClientes = cliente.Dame_por_nombre(tbNombre1.Text);
                dataGridView1.ClearSelection();
               
                for (int i = 0; i < listaClientes.Count; i++)
                {
                    
                    clienteEN = new ClientesEN();

                    listaDatos[0] = listaClientes[i].Dni;
                    listaDatos[1] = listaClientes[i].Nombre;
                    listaDatos[2] = listaClientes[i].Apellido;
                    listaDatos[3] = listaClientes[i].Email;
                    listaDatos[4] = listaClientes[i].Telefono;
                    listaDatos[5] = listaClientes[i].Direccion;
                    listaDatos[6] = listaClientes[i].Fecha;
                        
                          //  listaDatos[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                   // for (int j = 0; j < listaDatos.Length; j++)
                    int j = 0;
                    while( j < listaDatos.Length) 
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = listaDatos[j].ToString();
                        j++;
                    }
                    
                //    this.dataGridView1.Rows[i,0].Cells.Add(listaDatos[i].ToString());

            /*            clienteEN.Dni = listaDatos[0];
                        clienteEN.Nombre = listaDatos[1];
                        clienteEN.Apellido = listaDatos[2];
                        clienteEN.Email = listaDatos[3];
                        clienteEN.Telefono = listaDatos[4];
                        clienteEN.Direccion = listaDatos[5];
                        clienteEN.Fecha = listaDatos[6];

                        listaClientes.Add(clienteEN);
                    */
                    
                }
            }
            
        }
    }
}


