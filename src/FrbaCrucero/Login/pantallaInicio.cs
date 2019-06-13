using FrbaCrucero.Model.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Login
{
    public partial class PantallaInicio : Form
    {

        LoginAdmin loginAdmin;
        PantallaPrincipal pantallaPrincipal; 
        public PantallaInicio()
        {
            InitializeComponent();
            loginAdmin = new LoginAdmin();
            pantallaPrincipal = new PantallaPrincipal("CLIENTE");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}
