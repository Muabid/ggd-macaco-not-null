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
        private DataTable cabinas;
        private int crucero;
        private Model.CompraReservaPasaje.Cliente elCliente;
        private Model.Viajes.Viaje crucero1;


        public Pago(Model.CompraReservaPasaje.Cliente cliente, DataTable cabinas,int crucero )
        {

            this.cliente = cliente;
            this.cabinas = cabinas;
            this.crucero = crucero;

            InitializeComponent();
        }

        public Pago(Model.CompraReservaPasaje.Cliente elCliente, DataTable cabinas, Model.Viajes.Viaje crucero1)
        {
            // TODO: Complete member initialization
            this.elCliente = elCliente;
            this.cabinas = cabinas;
            this.crucero1 = crucero1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediosDeLosPagos form = new MediosDeLosPagos(cliente, cabinas, crucero);
            form.Show();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void botonBuscarReserva_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
