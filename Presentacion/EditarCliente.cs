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
            ClientesCAD clienteCAD = null;
            ClientesEN cliente = null;
            bool modificado = false;
            int k;
            k = dataGridView1.CurrentCell.RowIndex;

          //  dia = clienteCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()).Fecha;
                

            
            if (tbNombre.Text != "" && tbApellidos.Text != "" && tbEmail.Text != "" && tbTelefono.Text != "" && tbDireccion.Text != "" && tbFecha.Text != "")
            {
                if (tbNombre.Text == dataGridView1.Rows[k].Cells[1].Value.ToString()
                    && tbApellidos.Text == dataGridView1.Rows[k].Cells[2].Value.ToString()
                    && tbDireccion.Text == dataGridView1.Rows[k].Cells[5].Value.ToString()
                    && tbEmail.Text == dataGridView1.Rows[k].Cells[3].Value.ToString()
                    && tbFecha.Text == dia.ToString()
                    && tbTelefono.Text == dataGridView1.Rows[k].Cells[4].Value.ToString())
                {
                    MessageBox.Show("No se ha modificado nada");
                }
                else
                {
                    clienteCAD = new ClientesCAD();
                    cliente = new ClientesEN();
                    cliente.Dni = tbDni.Text;
                    cliente.Nombre = tbNombre.Text;
                    cliente.Apellido = tbApellidos.Text;
                    cliente.Email = tbEmail.Text;
                    cliente.Telefono = tbTelefono.Text;
                    cliente.Direccion = tbDireccion.Text;
                    cliente.Fecha = tbFecha.Text;
                    clienteCAD.Modify(cliente);
                    MessageBox.Show("Modificación correcta");
                    tbDni1.Text = "";
                    tbNombre1.Text = "";
                    modificado = true;
                    Limpiar();
                    this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet.Clientes);
                    tbDni.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("Falta rellenar algún dato");
            }
            if (modificado)
            {
                IList<ClientesEN> listaActualizada = new List<ClientesEN>();
                String[] listaDatos = new String[7];
                DataTable table1 = new DataTable();
                listaActualizada = clienteCAD.ReadAll(0, this.clientesBindingSource.Count);
                for (int i = 0; i < listaActualizada.Count; i++)
                {
                    listaDatos[0] = listaActualizada[i].Dni;
                    listaDatos[1] = listaActualizada[i].Nombre;
                    listaDatos[2] = listaActualizada[i].Apellido;
                    listaDatos[3] = listaActualizada[i].Email;
                    listaDatos[4] = listaActualizada[i].Telefono;
                    listaDatos[5] = listaActualizada[i].Direccion;
                    listaDatos[6] = listaActualizada[i].Fecha;

                    DataRow newRow1 = table1.NewRow();
                    table1.Rows.Add(newRow1);
                    dataGridView1.DataSource = table1;
                    int j = 0;
                    while (j < listaDatos.Length)
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = listaDatos[j].ToString();
                        j++;
                    }
                }
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
            ClientesCAD cliente = null;
            ClientesEN clienteEN = null;
            if (tbDni1.Text != "")
            {
                cliente = new ClientesCAD();
                clienteEN = new ClientesEN();
                if (cliente.ReadOID(tbDni1.Text) != null)
                {
                    clienteEN = cliente.ReadOID(tbDni1.Text);
                    tbNombre.Text = clienteEN.Nombre;
                    tbApellidos.Text = clienteEN.Apellido;
                    tbDni.Text = clienteEN.Dni;
                    tbDni.Enabled = false;
                    tbEmail.Text = clienteEN.Email;
                    tbTelefono.Text = clienteEN.Telefono;
                    tbDireccion.Text = clienteEN.Direccion;
                    tbFecha.Text = clienteEN.Fecha;
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                    tbDni1.Text = "";
                }

            }
            if (tbNombre1.Text != "")
            {
                cliente = new ClientesCAD();
                IList<ClientesEN> listaClientes = new List<ClientesEN>();
                String[] listaDatos = new String[7];
                // Aquí obtengo todos los clientes con el nombre que le paso por parametro.
                listaClientes = cliente.Dame_por_nombre(tbNombre1.Text);
                // Aquí controlo que el nombre este en la base de datos.
                if (listaClientes.Count != 0)
                {

                    DataTable table = new DataTable();

                    //Aquí recorro la lista de datos y inserto los datos de cada cliente recuperado de la base de datos.
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        listaDatos[0] = listaClientes[i].Dni;
                        listaDatos[1] = listaClientes[i].Nombre;
                        listaDatos[2] = listaClientes[i].Apellido;
                        listaDatos[3] = listaClientes[i].Email;
                        listaDatos[4] = listaClientes[i].Telefono;
                        listaDatos[5] = listaClientes[i].Direccion;
                        listaDatos[6] = listaClientes[i].Fecha;
                        //Aquí lo que hago es añadir una nueva linea en el dataGridView cada
                        // vez que encuentro un cliente en la base de datos para poder añadirlo 
                        // al dataGridView.
                        DataRow newRow = table.NewRow();
                        table.Rows.Add(newRow);
                        dataGridView1.DataSource = table;
                        int j = 0;
                        while (j < listaDatos.Length)
                        {
                            this.dataGridView1.Rows[i].Cells[j].Value = listaDatos[j].ToString();
                            j++;
                        }
                    } // Fin for

                }
                else
                {
                    MessageBox.Show("Ese nombre no existe");
                    tbNombre1.Text = "";
                }

            }// Fin if nombre ""
            if(tbNombre1.Text == "" && tbDni1.Text == "")
            {
                MessageBox.Show("Introduce un dato para filtrar");
            }
        
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


