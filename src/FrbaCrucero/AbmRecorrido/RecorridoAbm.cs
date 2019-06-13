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
    public partial class RecorridoAbm : Form
    {
        public RecorridoAbm()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Owner.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            BajaRecorrido fm = new BajaRecorrido();
            fm.ShowDialog(this);
        }   

        private void btnBaja_Click(object sender, EventArgs e)
        {
            AltaRecorrido fm = new AltaRecorrido();
            fm.ShowDialog(this);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            ListadoModificacionRecorrido fm = new ListadoModificacionRecorrido();
            fm.ShowDialog(this);
        }
    }
}
