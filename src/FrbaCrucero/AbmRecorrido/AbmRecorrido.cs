using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AbmRecorrido : Form
    {
        public AbmRecorrido()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            BajaRecorrido baja = new BajaRecorrido();
            baja.MdiParent = this;
            baja.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {

        }
    }
}
