using FrbaCrucero.Model.CompraReservaPasaje;
using FrbaCrucero.Model.Viajes;
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
    public partial class Reserva : Form
    {

        private Model.CompraReservaPasaje.Cliente cliente;
        private List<int> cabinasId;
        private int crucero;
        private DataTable cabinas;
        private Model.Viajes.Viaje viaje;


        public Reserva(Model.CompraReservaPasaje.Cliente cliente, List<int> cabinasId, int crucero)
        {

            this.cliente = cliente;
            this.cabinasId = cabinasId;
            this.crucero = crucero;
            this.cliente = cliente;
            InitializeComponent();
            textBox1.Text = cliente.dni.ToString();
            textBox2.Text = cliente.direccion;
            textBox3.Text = cliente.telefono.ToString();
            textBox4.Text = cliente.nombreApellido;
            textBox5.Text = cliente.mail;
            textBox6.Text = cliente.fechaNacimiento.ToString();
            textBox7.Text = crucero.ToString();

        }

        public Reserva(Cliente cliente, DataTable cabinas, Viaje viaje)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.cabinas = cabinas;
            pagoReservaTable.DataSource = cabinas;
            this.viaje = viaje;
            textBox1.Text = cliente.dni.ToString();
            textBox2.Text = cliente.direccion;
            textBox3.Text = cliente.telefono.ToString();
            textBox4.Text = cliente.nombreApellido;
            textBox5.Text = cliente.mail;
            textBox6.Text = cliente.fechaNacimiento.ToString();
            textBox7.Text = viaje.fecha_llegada_estimada.ToShortDateString();
            textBox8.Text = viaje.fecha_salida.ToShortDateString();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
         
        }

        private void pagoReservaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
