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
    public partial class MediosDePago : Form
    {
        public String codigo;

        public MediosDePago(String Codigo)
        {
            InitializeComponent();
            this.codigo = Codigo;
            reserva.Text = codigo;
            descripcion.Items.AddRange(new object[]{"TARJETA VISA", "TARJETA MASTERCARD", "TARJETA AMERICANEXPRESS", "TARJETA CREDENCIAL"});
            cantCuotas.Items.AddRange(new object[]{1, 2, 3, 6, 12});

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(cantCuotas.Text) && String.IsNullOrEmpty(descripcion.Text))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else if (String.IsNullOrEmpty(cantCuotas.Text))
            {
                MessageBox.Show("Ingrese la cantidad de cuotas");
            }
            else if(String.IsNullOrEmpty(descripcion.Text))
            {
                MessageBox.Show("Ingre el medio de pago");
            }
            else
            {
                String cuotas = cantCuotas.Text;
                String variable = descripcion.Text;

                string[] new_row = new string[2];
                new_row[0] =variable;
                new_row[1] = cuotas;
                tablaMediosDePago.Rows.Add(new_row);

                cantCuotas.SelectedIndex = -1;
                descripcion.SelectedIndex = -1;
            }

            

        }

        private void mediosDePago_Load(object sender, EventArgs e)
        {

        }

        private void tablaMediosDePago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == tablaMediosDePago.Columns["columnButtonDelete"].Index)
                {
                    tablaMediosDePago.Rows.RemoveAt(e.RowIndex);
                }
            }




         

        }

        private void botonRemover_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in tablaMediosDePago.SelectedRows)
            //{
            //    tablaMediosDePago.Rows.RemoveAt(row.Index);
            //}

            if (this.tablaMediosDePago.SelectedRows.Count > 0)
            { tablaMediosDePago.Rows.RemoveAt(this.tablaMediosDePago.SelectedRows[0].Index); }   



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonPagar_Click(object sender, EventArgs e)
        {

            Decimal cod_reserva = decimal.Parse(reserva.Text);
            SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarPagoReserva_Y_PasajesAlCliente");
            procedure.Parameters.Add("@codigo_reserva", SqlDbType.Decimal).Value = cod_reserva;
            Utils.Database.executeProcedure(procedure);


            foreach (DataGridViewRow row in tablaMediosDePago.Rows)
            {
                int var_cuotas = int.Parse(row.Cells["cuotas"].Value.ToString());
                String var_descripcion = row.Cells["methodOfPayment"].Value.ToString();

                SqlCommand procedure2 = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarMedioDePago_Al_NuevoPago");

                procedure2.Parameters.Add("@medio_Pago", SqlDbType.NVarChar).Value = var_descripcion;
                procedure2.Parameters.Add("@cantidad_cuotas", SqlDbType.Int).Value = var_cuotas;
                Utils.Database.executeProcedure(procedure2);
            }

            if (tablaMediosDePago.Rows.Count > 0)
            {



                SqlCommand procedure3 = Utils.Database.createCommand("MACACO_NOT_NULL.EliminarReserva");
                procedure3.Parameters.Add("@codigo_reserva", SqlDbType.Decimal).Value = cod_reserva;
                Utils.Database.executeProcedure(procedure3);
                MessageBox.Show("Se ha pagado la reserva ");
                this.Close();
            }
            else
            {

                MessageBox.Show("No se eligieron  medios de pago");
            }

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cantCuotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reserva_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
