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
    public partial class Animales : Form
    {
        String Cliente_OID;
        DataGridView nuevoDataGrid = new DataGridView();        
        public Animales()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            btInsertarDueño.Enabled = false;
            label12.Visible = false;
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Animales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet3.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.veterinaryManagerGenNHibernateDataSet3.Clientes);
            // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet22.Animales' table. You can move, or remove it, as needed.
            this.animalesTableAdapter1.Fill(this.veterinaryManagerGenNHibernateDataSet22.Animales);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btInsertarDueño.Enabled = true;
            AnimalesCAD animalCAD = new AnimalesCAD();
            AnimalesCEN animalCEN = null;
            tbID.Enabled = true;            
            btInsertarDueño.Text = "Insertar";
            if (animalCAD.ReadOID(tbID.Text) == null)
            {
                if (tbNombre.Text != "" && tbColor.Text != "" && tbRaza.Text != "" && tbSexo.Text != "" && tbEdad.Text != "" && tbID.Text != "" && tbCategoria.Text != "" && tbObservaciones.Text != "")
                {
                    animalCEN = new AnimalesCEN();
                    animalCEN.Nuevo_animal(tbNombre.Text, tbID.Text, tbCategoria.Text, tbRaza.Text, tbSexo.Text, tbColor.Text, tbObservaciones.Text, Convert.ToInt16(tbEdad.Text));
                    MessageBox.Show("Animal insertado correctamente");
                    dataGridView2.Visible = true;
                    label12.Visible = true;
                    button6.Enabled = false;
                    if (dataGridView2.Visible == true)
                    {
                        dataGridView1.Visible = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        groupBox1.Enabled = false;
                    }
                   Dame_Todos();
                }
                else
                {
                    MessageBox.Show("Tienes que rellenar todos los datos");
                }
            }
            else
            {
                MessageBox.Show("El animal ya existe");
                Limpiar();
            }
        }
        public void Limpiar()
        {
            tbNombre.Text = "";
            tbCategoria.Text = "";
            tbRaza.Text = "";
            tbSexo.Text = "";
            tbColor.Text = "";
            tbObservaciones.Text = "";
            tbEdad.Text = "";
            tbID.Text = "";
            tbID1.Text = "";
            tbNombre1.Text = "";
            tbCliente.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" && tbColor.Text != "" && tbRaza.Text != "" && tbSexo.Text != "" && tbEdad.Text != "" && tbID.Text != "" && tbCategoria.Text != "" && tbObservaciones.Text != "")
            {
                tbID.Enabled = true;
                AnimalesCAD animalCAD = new AnimalesCAD();
                AnimalesCEN animalCEN = new AnimalesCEN();
                int i;
                i = dataGridView1.CurrentCell.RowIndex;
                animalCEN.Modify(tbID.Text, tbNombre.Text, tbCategoria.Text, tbRaza.Text, tbSexo.Text, tbColor.Text, tbObservaciones.Text, Convert.ToInt32(tbEdad.Text));
                MessageBox.Show("Modificación correcta");               
             //   this.animalesTableAdapter1.Fill(this.veterinaryManagerGenNHibernateDataSet22.Animales);
                Dame_Todos();
                Limpiar();                
            }
            else
            {
                MessageBox.Show("Tienes que introducir todos los campos");
            }            
        }
        public void Dame_Todos()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.animalesTableAdapter1.Fill(this.veterinaryManagerGenNHibernateDataSet22.Animales);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnimalesCAD animalCAD = null;
            int i;
            if (dataGridView2.Visible == true)
            {
                i = dataGridView2.CurrentCell.RowIndex;
                tbCliente.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();// aqui cojo el nombre del cliente
                Cliente_OID = dataGridView2.Rows[i].Cells[0].Value.ToString();// aqui cojo el id del cliente.
            }
            else
            {
                animalCAD = new AnimalesCAD();
                i = dataGridView1.CurrentCell.RowIndex;
                tbID.Enabled = false;
                if (animalCAD.ReadOID(dataGridView1.Rows[i].Cells[0].Value.ToString()) != null)
                {
                    tbRaza.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    tbNombre.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    tbCategoria.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    tbColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    tbSexo.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    tbObservaciones.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    tbID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    tbEdad.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnimalesCEN animalCEN = null;
            if (tbNombre.Text != "" && tbColor.Text != "" && tbRaza.Text != "" && tbSexo.Text != "" && tbEdad.Text != "" && tbID.Text != "" && tbCategoria.Text != "" && tbObservaciones.Text != "")
            {
                animalCEN = new AnimalesCEN();
                animalCEN.Destroy(tbID.Text);
                MessageBox.Show("Borrado correcto");
                Limpiar();
                tbID.Enabled = true;
               // TODO: This line of code loads data into the 'veterinaryManagerGenNHibernateDataSet1.Clientes' table. You can move, or remove it, as needed.
             //   this.animalesTableAdapter1.Fill(this.veterinaryManagerGenNHibernateDataSet22.Animales);
                Dame_Todos();
                tbNombre1.Text = "";
                tbID1.Text = "";
            }
            else
            {
                MessageBox.Show("Falta rellenar algún dato");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnimalesCEN animalCEN = null;
            AnimalesEN animalEN = null;
            nuevoDataGrid = dataGridView1;

            if (tbID1.Text != "")
            {
                animalCEN = new AnimalesCEN();
                animalEN = new AnimalesEN();
                if (animalCEN.ReadOID(tbID1.Text) != null)
                {
                    animalEN = animalCEN.ReadOID(tbID1.Text);
                    tbNombre.Text = animalEN.Nombre;
                    tbCategoria.Text = animalEN.Categoria;
                    tbID.Text = animalEN.Id;
                    tbRaza.Text = animalEN.Raza;
                    tbSexo.Text = animalEN.Sexo;
                    tbColor.Text = animalEN.Color;
                    tbObservaciones.Text = animalEN.Observaciones;
                    tbEdad.Text = animalEN.Edad.ToString();
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                    tbID1.Text = "";
                }
            }  // Fin tbID1 != ""
            if (tbNombre1.Text != "")
            {
                animalCEN = new AnimalesCEN();
                IList<AnimalesEN> listaAnimales = new List<AnimalesEN>();                
                String[] listaDatos = new String[8];
                // Aquí obtengo todos los animales con el nombre que le paso por parametro.
                listaAnimales = animalCEN.Dame_por_nombre(tbNombre1.Text.ToString());
                // Aquí controlo que no sea la lista vacia.
                if (listaAnimales.Count != 0)
                {                    
                    DataTable table = new DataTable();
                    //Aquí recorro la lista de datos y inserto los datos de cada cliente recuperado de la base de datos.
                    for (int i = 0; i < listaAnimales.Count; i++)
                    {

                        listaDatos[0] = listaAnimales[i].Id;
                        listaDatos[1] = listaAnimales[i].Nombre;
                        listaDatos[2] = listaAnimales[i].Categoria;
                        listaDatos[3] = listaAnimales[i].Raza;
                        listaDatos[4] = listaAnimales[i].Sexo;
                        listaDatos[5] = listaAnimales[i].Color;
                        listaDatos[6] = listaAnimales[i].Observaciones;
                        listaDatos[7] = listaAnimales[i].Edad.ToString();
                        //  listaDatos[8] = listaAnimales[i].Clientes.Nombre;     !!!!!!!!!!!!! problemas al insertar una clave ajena de la tabla cliente... LazyException
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
        private void btInsertarDueño_Click(object sender, EventArgs e)
        {
            AnimalesCEN animalCEN = new AnimalesCEN();
            animalCEN.Add_cliente(tbID.Text, Cliente_OID); // Aquí le paso el oid del cliente que recogi antes en editar.
            Dame_Todos();
            dataGridView1.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            groupBox1.Enabled = true;
            dataGridView2.Visible = false;
            Limpiar();
            button6.Enabled = true;
            label12.Visible = false;
            btInsertarDueño.Text = "Dueño";
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            tbID.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
