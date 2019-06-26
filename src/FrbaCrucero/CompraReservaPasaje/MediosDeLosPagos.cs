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
    public partial class MediosDeLosPagos : Form
    {
        private Model.CompraReservaPasaje.Cliente cliente;
        private List<int> cabinasId;
        private int crucero;
        private DataTable cabinas;


        public MediosDeLosPagos(Model.CompraReservaPasaje.Cliente cliente, List<int> cabinasId, int crucero)
        {

            this.cliente = cliente;
            this.cabinasId = cabinasId;
            this.crucero = crucero;

            InitializeComponent();
        }

        public MediosDeLosPagos(Model.CompraReservaPasaje.Cliente cliente, DataTable cabinas, int crucero)
        {
            // TODO: Complete member initialization
            this.cliente = cliente;
            this.cabinas = cabinas;
            this.crucero = crucero;
        }

        private void botonPagar_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            String cuotas = cantCuotas.Text;
            String variable = descripcion.Text;

            string[] new_row = new string[2];
            new_row[0] = variable;
            new_row[1] = cuotas;
            tablaMediosDePago.Rows.Add(new_row);
        }

        private void MediosDeLosPagos_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
