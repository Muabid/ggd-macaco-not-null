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


        public PantallaInicio()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show(this);
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            new PantallaPrincipal("CLIENTE").ShowDialog(this);
        }
    }
}
