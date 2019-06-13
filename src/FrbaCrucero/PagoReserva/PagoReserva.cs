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

            mediosDePago nuevo = new mediosDePago(codigoReservaBox.Text);

            nuevo.Show();

            this.Hide();
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

                this.pagoReservaTable.Rows.Clear();//arreglar error 
                this.pagoReservaTable.Refresh();
            }

        }

        private void botonBuscarReserva_Click(object sender, EventArgs e)
        {



            SqlCommand cmd = Utils.Database.createCommand("SELECT  MACACO_NOT_NULL.ComprobarExistenciaReserva(@codigo)");

            SqlParameter value = new SqlParameter("@codigo", SqlDbType.Decimal);

            value.Value = Decimal.Parse(codigoReservaBox.Text);

            cmd.Parameters.Add(value);

            int resultado = Utils.Database.executeScalar(cmd);

            
            if (resultado == 1)
            {

                MessageBox.Show("Existe la reserva");
           
                pagoReservaTable.DataSource = this.getReservas(Decimal.Parse(codigoReservaBox.Text));

            }
            else
            {
                MessageBox.Show("No existe la reserva");

            }

        }




        public DataTable getReservas(Decimal codigoReserva)
        {
            SqlCommand cmd = Utils.Database.createCommand("SELECT * FROM  MACACO_NOT_NULL.DetallesReserva(@codigo_reserva)");

            SqlParameter a_cod_reserva = cmd.Parameters.Add("@codigo_reserva", SqlDbType.Decimal);

            //if (!Decimal.(codigoReserva))
                a_cod_reserva.Value = codigoReserva;
            //else
            //    a_cod_reserva.Value = DBNull.Value;


            return Utils.Database.getData(cmd);
        }

        private void PagoReserva_Load(object sender, EventArgs e)
        {

        }



    }
}