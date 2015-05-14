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
    public partial class Tratamientos : Form
    {
        String Animal_OID;
        bool editarAnimal = false;
        DataGridView nuevoDataGrid = new DataGridView(); 
        public Tratamientos()
        {
            InitializeComponent();
            btInsertarAnimal.Enabled = false;
            tbAnimal.Enabled = false;
            label11.Enabled = false;
            label12.Visible = false;
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
            TratamientosCEN trataCEN = new TratamientosCEN();

            if (trataCEN.ReadOID(tbID.Text) == null)
            {
                if (tbNombre.Text != "" && tbPrecio.Text != "" && tbFecha_Ini.Text != "" && tbFecha_fin.Text != "" && tbID.Text != "")
                {
                    trataCEN = new TratamientosCEN();
                    //   float precio = float.Parse(tbPrecio.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en-US"));
                    trataCEN.Nuevo_tratamiento(tbNombre.Text, float.Parse(tbPrecio.Text), tbFecha_Ini.Text, tbFecha_fin.Text, tbID.Text);

                    MessageBox.Show("Elige un animal para el tratamiento y pulsa editar");
                    Dame_Todos();
                    btInsertarAnimal.Text = "Insertar";
                    button6.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    btBuscar.Enabled = false;
                    btInsertarAnimal.Enabled = true;
                    tbID.Enabled = false;
                    label12.Visible = true;
                    dataGridView1.Visible = false;
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
                MessageBox.Show("Tienes que editar el tratamiento");
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
                btBuscar.Enabled = true;
                btInsertarAnimal.Text = "Insertar";
                dataGridView1.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" && tbPrecio.Text != "" && tbFecha_Ini.Text != "" && tbFecha_fin.Text != "" && tbID.Text != "")
            {
                TratamientosCEN trataCEN = new TratamientosCEN();
                int i;
                i = dataGridView1.CurrentCell.RowIndex;
                trataCEN.Modify(tbID.Text, tbNombre.Text, float.Parse(tbPrecio.Text), tbFecha_Ini.Text, tbFecha_fin.Text);
                MessageBox.Show("Modificación correcta");
                //   this.animalesTableAdapter1.Fill(this.veterinaryManagerGenNHibernateDataSet22.Animales);
                Dame_Todos();
                Limpiar();
                tbID.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tienes que introducir todos los campos");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            TratamientosCEN trataCEN = null;
            TratamientosEN trataEN = null;
            nuevoDataGrid = dataGridView1;

            if (tbID1.Text != "")
            {
                trataCEN = new TratamientosCEN();
                trataEN = new TratamientosEN();
                if (trataCEN.ReadOID(tbID1.Text) != null)
                {
                    trataEN = trataCEN.ReadOID(tbID1.Text);
                    tbNombre.Text = trataEN.Nombre;
                    tbPrecio.Text = trataEN.Precio.ToString();
                    tbID.Text = trataEN.Id;
                    tbFecha_fin.Text = trataEN.Fecha_fin;
                    tbFecha_Ini.Text = trataEN.Fecha_inicio;
                  //  tbAnimal.Text = trataEN.Animales.Nombre;  // Aqui lanza exception...
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                    tbID1.Text = "";
                }
            }  // Fin tbID1 != ""
            if (tbNombre1.Text != "")
            {
                trataCEN = new TratamientosCEN();
                IList<TratamientosEN> listaTratamientos = new List<TratamientosEN>();
                String[] listaDatos = new String[5];
                // Aquí obtengo todos los animales con el nombre que le paso por parametro.
                listaTratamientos = trataCEN.Dame_por_nombre(tbNombre1.Text.ToString());
                // Aquí controlo que no sea la lista vacia.
                if (listaTratamientos.Count != 0)
                {
                    DataTable table = new DataTable();
                    //Aquí recorro la lista de datos y inserto los datos de cada cliente recuperado de la base de datos.
                    for (int i = 0; i < listaTratamientos.Count; i++)
                    {

                        listaDatos[0] = listaTratamientos[i].Id;
                        listaDatos[1] = listaTratamientos[i].Nombre;
                        listaDatos[2] = listaTratamientos[i].Precio.ToString();
                        listaDatos[3] = listaTratamientos[i].Fecha_inicio;
                        listaDatos[4] = listaTratamientos[i].Fecha_fin;
                        //  listaDatos[5] = listaTratamientos[i].Animales.Nombre;     !!!!!!!!!!!!! problemas al insertar una clave ajena de la tabla cliente... LazyException
                        //Aquí lo que hago es añadir una nueva linea en el dataGridView cada
                        // vez que encuentro un cliente en la base de datos para poder añadirlo 
                        // al dataGridView.
                        DataRow newRow = table.NewRow();
                        table.Rows.Add(newRow);
                        nuevoDataGrid.DataSource = table;
                        // dataGridView1.DataSource = table;
                        int j = 0;
                        while (j < listaDatos.Length)
                        {
                            nuevoDataGrid.Rows[i].Cells[j].Value = listaDatos[j].ToString();
                            //dataGridView1.Rows[i].Cells[j].Value = listaDatos[j].ToString();
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
        }
    }
}
