using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;
using VeterinaryManagerGenNHibernate.CAD.VeterinaryManager;

namespace Presentacion
{
    public partial class Servicios : Form
    {
        ServicioCEN servicio = null;
        ServicioCAD servicioCAD = null;
        int OID,i;
        public Servicios()
        {
            InitializeComponent();
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet5.Servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet5.Servicio);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (tbNombre.Text != "" && tbTipo.Text != "" && tbFecha.Text != "")
            {
                servicio = new ServicioCEN();
                servicio.Nuevo_servicio(tbNombre.Text, tbTipo.Text, tbFecha.Text);
                Dame_Todos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Falta algún dato");
            }
               
        }
        public void Dame_Todos()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.servicioTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet5.Servicio);
        }
        public void Limpiar()
        {
            tbNombre.Text = "";
            tbFecha.Text = "";
            tbTipo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" && tbTipo.Text != "" && tbFecha.Text != "")
            {
                servicio = new ServicioCEN();
                servicio.Destroy(OID);
                Dame_Todos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que editar el servicio");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = dataGridView1.CurrentCell.RowIndex;
            OID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            tbFecha.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tbNombre.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbTipo.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();           
        }
    }
}
