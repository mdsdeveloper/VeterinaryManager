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
    
    public partial class ModificarCliente : Form
    {
        String dia;
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet.Clientes);

        }

        private void btEditar_Click(object sender, EventArgs e)
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

        private void btModificar_Click(object sender, EventArgs e)
        {
            ClientesCAD clienteCAD = new ClientesCAD();
            ClientesCEN cliente = new ClientesCEN();
            int i;
            i = dataGridView1.CurrentCell.RowIndex;
            dia = clienteCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()).Fecha;
            cliente.Modify(tbDni.Text, tbNombre.Text, tbApellidos.Text, tbEmail.Text, tbTelefono.Text, tbDireccion.Text, dia);
            MessageBox.Show("Modificación correcta");
            Limpiar();
            this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet.Clientes);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

