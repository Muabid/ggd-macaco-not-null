using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormPantallaInicio : Form
    {
        public FormPantallaInicio()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Application.Run(new AbmCrucero.FormAlta());
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Application.Run(new AbmCrucero.FormBaja());
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            Application.Run(new AbmCrucero.FormModificacion());
        }
    }
}
