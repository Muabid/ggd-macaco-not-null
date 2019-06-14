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
    public partial class FormListadoCruceros : Form
    {

        private Utils.CruceroDAO cruceroDao = new Utils.CruceroDAO();


        public FormListadoCruceros()
        {
            InitializeComponent();
        }

        private void FormListadoCruceros_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //LIMPIAR PANTALLA
        }
    }
}
