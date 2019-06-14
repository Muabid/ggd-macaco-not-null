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
        private Utils.CruceroDAO cruceroDao = new Utils.CruceroDAO;

        public FormListadoCruceros()
        {
            InitializeComponent();
            /* ACA EMPECÉ A SEGUIR LA MISMA LÓGICA QUE ESTABA EN LISTADO RECORRIDO
             * PERO CAMBIANDO LA QUERY CORRESPONDIENTE
            foreach()
            cbo_modelo.Items.Add(Utils.Database.createCommand("SELECT DISTINCT cruc_modelo FROM MACACO_NOT_NULL.CRUCERO");
            cbo_compania.Items.Add(Utils.Database.createCommand("SELECT comp_nombre FROM MACACO_NOT_NULL.COMPANIA");
             */
        }

        private void FormListadoCruceros_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
