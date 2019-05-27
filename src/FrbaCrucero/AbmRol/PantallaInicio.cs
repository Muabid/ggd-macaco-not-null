using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class InicioRol : Form
    {
        public InicioRol()
        {
            InitializeComponent();
        }

        private void NuevaVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaRol frm1 = new AltaRol();

            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baja frm3 = new Baja();

            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormularioModificacion frm2 = new FormularioModificacion();

            frm2.Show();
        }
    }
}
