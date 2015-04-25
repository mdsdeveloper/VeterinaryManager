using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            UsuarioCEN usuarioCEN = null;
            usuarioCEN = new UsuarioCEN();

            if (tbUsuario.Text != null && tbContraseña.Text != null)
            {
                if (usuarioCEN.Login(tbContraseña.Text, tbUsuario.Text) == true)
                {
                    MessageBox.Show("Bienbenido a Veterinary Manager");
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show("Login incorrecto");
                }
            }
        }
    }
}
