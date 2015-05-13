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
    public partial class Tratamientos : Form
    {
        String Animal_OID;
        bool editarAnimal = false;
        public Tratamientos()
        {
            InitializeComponent();
            btInsertarAnimal.Enabled = false;
            tbAnimal.Enabled = false;
            label11.Enabled = false;
        }

        private void Tratamientos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet4.Tratamientos' table. You can move, or remove it, as needed.
            this.tratamientosTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet4.Tratamientos);
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet2.Animales' table. You can move, or remove it, as needed.
            this.animalesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet2.Animales);
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            tbFecha_Ini.Text = "";
            tbFecha_fin.Text = "";
            tbID.Text = "";
            tbID1.Text = "";
            tbNombre1.Text = "";
            tbAnimal.Text = "";
            tbID.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosCAD trataCAD = new TratamientosCAD();
            TratamientosCEN trataCEN = new TratamientosCEN();

            if (trataCEN.ReadOID(tbID.Text) == null)
            {
                if (tbNombre.Text != "" && tbPrecio.Text != "" && tbFecha_Ini.Text != "" && tbFecha_fin.Text != "" && tbID.Text != "")
                {
                    trataCEN = new TratamientosCEN();
                    //   float precio = float.Parse(tbPrecio.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
                    trataCEN.Nuevo_tratamiento(tbNombre.Text, float.Parse(tbPrecio.Text), tbFecha_Ini.Text, tbFecha_fin.Text, tbID.Text);

                    MessageBox.Show("Tratamiento insertado correctamente");
                    Dame_Todos();
                    btInsertarAnimal.Text = "Insertar";
                    button6.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    btBuscar.Enabled = false;
                    btInsertarAnimal.Enabled = true;
                    tbID.Enabled = false;
                    editarAnimal = true; // con esto controlo que se llame a editar de animales o tratamiento.
                  //  Limpiar();
                }
                else
                {
                    MessageBox.Show("Tienes que rellenar todos los datos");
                } 
            }
            else
            {
                MessageBox.Show("El tratamiento ya existe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TratamientosCAD tratamientoCAD = null;
            int i;
            if (editarAnimal == true)
            {
                i = dataGridView2.CurrentCell.RowIndex;
                tbAnimal.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();// aqui cojo el nombre del cliente
                Animal_OID = dataGridView2.Rows[i].Cells[0].Value.ToString();// aqui cojo el id del cliente.
                editarAnimal = false;
            }
            else
            {
                tratamientoCAD = new TratamientosCAD();
                i = dataGridView1.CurrentCell.RowIndex;
                tbID.Enabled = false;
                if (tratamientoCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()) != null)
                {
                    tbNombre.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    tbID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    tbPrecio.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    tbFecha_Ini.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    tbFecha_fin.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("El tratamiento no existe");
                }
            }
        }
        public void Dame_Todos()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.tratamientosTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet4.Tratamientos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TratamientosCEN trataCEN = null;
            if (tbNombre.Text != "" && tbPrecio.Text != "" && tbFecha_Ini.Text != "" && tbFecha_fin.Text != "" && tbID.Text != "")
            {
                trataCEN = new TratamientosCEN();
                trataCEN.Destroy(tbID.Text);
                MessageBox.Show("Borrado correcto");
                Limpiar();
                tbID.Enabled = true;
                Dame_Todos();
                tbNombre1.Text = "";
                tbID1.Text = "";
            }
            else
            {
                MessageBox.Show("Falta rellenar algún dato");
            }
        }

        private void btInsertarAnimal_Click(object sender, EventArgs e)
        {
            TratamientosCEN trataCEN = new TratamientosCEN();
            trataCEN.Add_animal(tbID.Text, Animal_OID); // Aquí le paso el oid del cliente que recogi antes en editar.
            Dame_Todos();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            Limpiar();
            button6.Enabled = true;
            btInsertarAnimal.Text = "Insertar";
        }
    }
}
