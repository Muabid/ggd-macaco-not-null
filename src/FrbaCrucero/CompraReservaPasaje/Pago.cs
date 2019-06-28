using FrbaCrucero.Model.Cruceros;
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
        private List<Cabina> cabinas;
        private int crucero;
        private Model.CompraReservaPasaje.Cliente elCliente;
        private Model.Viajes.Viaje crucero1;


        public Pago(Model.CompraReservaPasaje.Cliente cliente, List<Cabina> cabinas, int crucero)
        {

            this.cliente = cliente;
            this.cabinas = cabinas;
            this.crucero = crucero;

            InitializeComponent();
        }

        public Pago(Model.CompraReservaPasaje.Cliente cliente, List<Cabina> cabinas, Model.Viajes.Viaje viaje)
        {
            InitializeComponent();
            this.elCliente = cliente;
            this.cabinas = cabinas;
            this.crucero1 = viaje;
            for (int i = 0; i < cabinas.Count; i++)
            {
                Cabina unaCabina = cabinas.ElementAt(i);
                String nro = unaCabina.cabi_nro.ToString();
                String piso = unaCabina.cabi_piso.ToString();
                String tipoServicio = unaCabina.cabi_tipo_servicio_descr.ToString();
                string[] new_row = new string[3];
                new_row[0] = nro;
                new_row[1] = piso;
                new_row[2] = tipoServicio;
                pagoReservaTable.Rows.Add(new_row);
            }

            //pagoReservaTable.DataSource = cabinas;         
            textBox1.Text = cliente.dni.ToString();
            textBox2.Text = cliente.direccion;
            textBox3.Text = cliente.telefono.ToString();
            textBox4.Text = cliente.nombreApellido;
            textBox5.Text = cliente.mail;
            textBox6.Text = cliente.fechaNacimiento.ToString();
            textBox7.Text = viaje.fecha_llegada_estimada.ToShortDateString();
            textBox8.Text = viaje.fecha_salida.ToShortDateString();
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
