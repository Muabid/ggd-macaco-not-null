using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.PagoReserva
{
    public partial class PagoReserva : Form
    {
        public PagoReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.AltaRol");
            procedure.Parameters.Add("@nombre_rol", SqlDbType.NVarChar).Value = NombreNuevoRol.Text;
            procedure.Parameters.Add("@activo", SqlDbType.Bit).Value = 1;
            Utils.Database.executeProcedure(procedure); */

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            if (this.pagoReservaTable.Rows.Count > 0)
            {

                this.pagoReservaTable.Rows.Clear();
                this.pagoReservaTable.Refresh();
            }

        }
    }
}
