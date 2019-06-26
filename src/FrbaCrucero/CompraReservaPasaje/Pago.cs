using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Pago : Form
    {   
        private Model.CompraReservaPasaje.Cliente cliente;
        private List<int> cabinasId;
        private int crucero;


        public Pago(Model.CompraReservaPasaje.Cliente cliente, List<int> cabinasId,int crucero )
        {

            this.cliente = cliente;
            this.cabinasId = cabinasId;
            this.crucero = crucero;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediosDeLosPagos form = new MediosDeLosPagos(cliente, cabinasId, crucero);
            form.Show();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }
    }
}
