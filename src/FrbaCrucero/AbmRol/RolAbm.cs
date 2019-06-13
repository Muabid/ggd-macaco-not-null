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
    public partial class RolAbm : Form
    {
        public RolAbm()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol();
            alta.ShowDialog(this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.ShowDialog(this);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            Modificacion modificacion = new Modificacion();
            modificacion.ShowDialog(this);
        }
    }
}
