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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cuotas = cantCuotas.Text;
            String variable = descripcion.Text;
            //DataTable dt = tablaMediosDePago.DataSource as DataTable;
            //    if (cuotas != null && variable != null && dt != null)
            //    {

            //        DataRow row = dt.NewRow();
            //        row["methodOfPayment"] = variable;
            //        row["cuotas"] = cuotas;
            //        dt.Rows.Add(row);
            //   }




                string[] new_row = new string[2];
                new_row[0] =variable;
                new_row[1] = cuotas;
                tablaMediosDePago.Rows.Add(new_row);

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
            {   int var_cuotas = int.Parse(row.Cells["cuotas"].Value.ToString());
                String var_descripcion= row.Cells["methodOfPayment"].Value.ToString();
               
               SqlCommand procedure2 = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarMedioDePago_Al_NuevoPago");
                 
               procedure2.Parameters.Add("@medio_Pago", SqlDbType.NVarChar).Value = var_descripcion;
                procedure2.Parameters.Add("@cantidad_cuotas", SqlDbType.Int).Value = var_cuotas;
                Utils.Database.executeProcedure(procedure2);
            }

             SqlCommand procedure3 = Utils.Database.createCommand("MACACO_NOT_NULL.EliminarReserva");
             procedure3.Parameters.Add("@codigo_reserva", SqlDbType.Decimal).Value = cod_reserva;
             Utils.Database.executeProcedure(procedure3);
             MessageBox.Show("Se ha pagado la reserva ");
             this.Hide();
             PagoReserva pago = new PagoReserva();
             pago.Show();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagoReserva pago = new PagoReserva();
            pago.Show();
        }

     
    }
}
