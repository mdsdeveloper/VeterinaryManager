namespace Presentacion
{
    partial class Tratamientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinaryManagerGenNHibernateDataSet4 = new Presentacion.VeterinaryManagerGenNHibernateDataSet4();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.animalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinaryManagerGenNHibernateDataSet2 = new Presentacion.VeterinaryManagerGenNHibernateDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.btInsertarAnimal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID1 = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbNombre1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbFecha_fin = new System.Windows.Forms.TextBox();
            this.tbFecha_Ini = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animalesTableAdapter = new Presentacion.VeterinaryManagerGenNHibernateDataSet2TableAdapters.AnimalesTableAdapter();
            this.tratamientosTableAdapter = new Presentacion.VeterinaryManagerGenNHibernateDataSet4TableAdapters.TratamientosTableAdapter();
            this.idTratamientosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidAnimalesidAnimalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnimalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinaryManagerGenNHibernateDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinaryManagerGenNHibernateDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTratamientosDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn,
            this.fKidAnimalesidAnimalesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tratamientosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 223);
            this.dataGridView1.TabIndex = 16;
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "Tratamientos";
            this.tratamientosBindingSource.DataSource = this.veterinaryManagerGenNHibernateDataSet4;
            // 
            // veterinaryManagerGenNHibernateDataSet4
            // 
            this.veterinaryManagerGenNHibernateDataSet4.DataSetName = "VeterinaryManagerGenNHibernateDataSet4";
            this.veterinaryManagerGenNHibernateDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimalesDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.animalesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(693, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 225);
            this.dataGridView2.TabIndex = 15;
            // 
            // animalesBindingSource
            // 
            this.animalesBindingSource.DataMember = "Animales";
            this.animalesBindingSource.DataSource = this.veterinaryManagerGenNHibernateDataSet2;
            // 
            // veterinaryManagerGenNHibernateDataSet2
            // 
            this.veterinaryManagerGenNHibernateDataSet2.DataSetName = "VeterinaryManagerGenNHibernateDataSet2";
            this.veterinaryManagerGenNHibernateDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbAnimal);
            this.groupBox2.Controls.Add(this.btInsertarAnimal);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.tbFecha_fin);
            this.groupBox2.Controls.Add(this.tbFecha_Ini);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 216);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos animales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(213, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Elige el animal que recibe tratamiento y pulsa editar";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(130, 139);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(310, 20);
            this.tbID.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(708, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 30);
            this.button4.TabIndex = 20;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nombre del animal";
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(130, 168);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(310, 20);
            this.tbAnimal.TabIndex = 18;
            // 
            // btInsertarAnimal
            // 
            this.btInsertarAnimal.Location = new System.Drawing.Point(596, 123);
            this.btInsertarAnimal.Name = "btInsertarAnimal";
            this.btInsertarAnimal.Size = new System.Drawing.Size(87, 30);
            this.btInsertarAnimal.TabIndex = 17;
            this.btInsertarAnimal.Text = "Animal";
            this.btInsertarAnimal.UseVisualStyleBackColor = true;
            this.btInsertarAnimal.Click += new System.EventHandler(this.btInsertarAnimal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbID1);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.tbNombre1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(469, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dni";
            // 
            // tbID1
            // 
            this.tbID1.Location = new System.Drawing.Point(103, 21);
            this.tbID1.Name = "tbID1";
            this.tbID1.Size = new System.Drawing.Size(210, 21);
            this.tbID1.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(346, 30);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(87, 30);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbNombre1
            // 
            this.tbNombre1.Location = new System.Drawing.Point(103, 46);
            this.tbNombre1.Name = "tbNombre1";
            this.tbNombre1.Size = new System.Drawing.Size(210, 21);
            this.tbNombre1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(815, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(815, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "Cerrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbFecha_fin
            // 
            this.tbFecha_fin.Location = new System.Drawing.Point(130, 112);
            this.tbFecha_fin.Name = "tbFecha_fin";
            this.tbFecha_fin.Size = new System.Drawing.Size(310, 20);
            this.tbFecha_fin.TabIndex = 11;
            // 
            // tbFecha_Ini
            // 
            this.tbFecha_Ini.Location = new System.Drawing.Point(130, 83);
            this.tbFecha_Ini.Name = "tbFecha_Ini";
            this.tbFecha_Ini.Size = new System.Drawing.Size(310, 20);
            this.tbFecha_Ini.TabIndex = 10;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(130, 56);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(310, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(130, 30);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(310, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // animalesTableAdapter
            // 
            this.animalesTableAdapter.ClearBeforeFill = true;
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // idTratamientosDataGridViewTextBoxColumn
            // 
            this.idTratamientosDataGridViewTextBoxColumn.DataPropertyName = "idTratamientos";
            this.idTratamientosDataGridViewTextBoxColumn.HeaderText = "ID_Tratamientos";
            this.idTratamientosDataGridViewTextBoxColumn.Name = "idTratamientosDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha_Inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "Fecha_Fin";
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            // 
            // fKidAnimalesidAnimalesDataGridViewTextBoxColumn
            // 
            this.fKidAnimalesidAnimalesDataGridViewTextBoxColumn.DataPropertyName = "FK_idAnimales_idAnimales";
            this.fKidAnimalesidAnimalesDataGridViewTextBoxColumn.HeaderText = "ID_Animal";
            this.fKidAnimalesidAnimalesDataGridViewTextBoxColumn.Name = "fKidAnimalesidAnimalesDataGridViewTextBoxColumn";
            // 
            // idAnimalesDataGridViewTextBoxColumn
            // 
            this.idAnimalesDataGridViewTextBoxColumn.DataPropertyName = "idAnimales";
            this.idAnimalesDataGridViewTextBoxColumn.HeaderText = "ID_Animales";
            this.idAnimalesDataGridViewTextBoxColumn.Name = "idAnimalesDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tratamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.Tratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinaryManagerGenNHibernateDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinaryManagerGenNHibernateDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.Button btInsertarAnimal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbNombre1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbFecha_fin;
        private System.Windows.Forms.TextBox tbFecha_Ini;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private VeterinaryManagerGenNHibernateDataSet2 veterinaryManagerGenNHibernateDataSet2;
        private System.Windows.Forms.BindingSource animalesBindingSource;
        private VeterinaryManagerGenNHibernateDataSet2TableAdapters.AnimalesTableAdapter animalesTableAdapter;
        private VeterinaryManagerGenNHibernateDataSet4 veterinaryManagerGenNHibernateDataSet4;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private VeterinaryManagerGenNHibernateDataSet4TableAdapters.TratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidAnimalesidAnimalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnimalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
    }
}