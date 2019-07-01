using FrbaCrucero.Model.CompraReservaPasaje;
using FrbaCrucero.Model.Cruceros;
using FrbaCrucero.Model.Viajes;
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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Reserva : Form
    {

        private Model.CompraReservaPasaje.Cliente cliente;
        private List<Cabina> cabinasElegidas;
        private int crucero;
        private DataTable cabinas;
        private Model.Viajes.Viaje viaje;


     //   public Reserva(Model.CompraReservaPasaje.Cliente cliente, List<Cabina> cabinasElegidas, int crucero)
      //  {
      //      InitializeComponent();
      //      this.cliente = cliente;
     //       this.cabinasElegidas = cabinasElegidas;
     //       this.crucero = crucero;
      //      this.cliente = cliente;         
      //      textBox1.Text = cliente.dni.ToString();
      //      textBox2.Text = cliente.direccion;
      //      textBox3.Text = cliente.telefono.ToString();
      //      textBox4.Text = cliente.nombreApellido;
      //      textBox5.Text = cliente.mail;
      //      textBox6.Text = cliente.fechaNacimiento.ToString();
      //      textBox7.Text = crucero.ToString();

     //   }

        public Reserva(Cliente cliente, List<Cabina> cabinas, Viaje viaje)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.cabinasElegidas = cabinas;
            this.viaje = viaje;

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
            textBox9.Text = viaje.crucero_id.ToString();
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

        private void btn_atras_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {   
            SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.[GenerarReserva]");
            procedure.Parameters.Add("@id_usuario", SqlDbType.Int).Value = cliente.id;
            procedure.Parameters.Add("@idViaje", SqlDbType.Int).Value = viaje.id;
            Utils.Database.executeProcedure(procedure);
                    
            SqlCommand query = Utils.Database.createCommand("SELECT top 1 rese_id FROM [MACACO_NOT_NULL].RESERVA order by rese_id desc");
            int reserva_id = Utils.Database.executeScalar(query);        
            for (int i = 0; i < cabinasElegidas.Count; i++)
            {
                Cabina unaCabina = cabinasElegidas.ElementAt(i);
                int cabi_id = unaCabina.cabi_id;
                SqlCommand procedure2 = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarCabina_Reserva");
                procedure2.Parameters.Add("@cab_id_pasaje", SqlDbType.Int).Value = cabi_id;
                procedure2.Parameters.Add("@reserva_id", SqlDbType.Int).Value = reserva_id;
                Utils.Database.executeProcedure(procedure2);
                
            }
            MessageBox.Show("Reserva Realizada - Codigo: " + reserva_id.ToString());
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
     

            this.pagoReservaTable.Rows.Clear();
            this.pagoReservaTable.Refresh();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
        }
    }
}
