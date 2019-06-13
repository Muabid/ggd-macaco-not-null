using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.PagoReserva
{
    public partial class mediosDePago : Form
    {
        public String codigo;

        public mediosDePago(String Codigo)
        {
            InitializeComponent();
            this.codigo = Codigo;
            reserva.Text = codigo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaMediosDePago.Rows.Add();
        }

        private void mediosDePago_Load(object sender, EventArgs e)
        {

        }

     
    }
}
