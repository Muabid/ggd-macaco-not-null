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
            new FormAlta().ShowDialog(this);
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            new FormListadoCruceros().ShowBaja(this);
        }

        private void btn_modificacion_Click(object sender, EventArgs e)
        {
            new FormListadoCruceros().ShowModificar(this);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
