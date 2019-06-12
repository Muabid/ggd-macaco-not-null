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

                this.pagoReservaTable.Rows.Clear();
                this.pagoReservaTable.Refresh();
            }

        }

        private void botonBuscarReserva_Click(object sender, EventArgs e)
        {


            //sqlparameter codigo = new sqlparameter("@codigo", sqldbtype.decimal);
            //codigo.value = decimal.parse(codigoreservabox.text);

            //sqlcommand function = utils.database.createcommand("select macaco_not_null.comprobarexistenciareserva(@codigo)");

            // messagebox.show(codigoreservabox.text);

            //decimal resultado = utils.database.executescalardecimal(function);









            SqlCommand cmd = new SqlCommand("SELECT  MACACO_NOT_NULL.ComprobarExistenciaReserva(@codigo)");

            SqlParameter value = new SqlParameter("@Value", SqlDbType.Decimal);

            value.Value = Decimal.Parse(codigoReservaBox.Text);

            cmd.Parameters.Add(value);

            decimal resultado = Utils.Database.executeScalarDecimal(cmd);

            
            if (resultado == 1)
            {

                MessageBox.Show("Existe la reserva");
                SqlCommand function2 = Utils.Database.createCommand("MACACO_NOT_NULL.DetallesReserva");
                function2.Parameters.Add("@codigo_reserva", SqlDbType.Decimal).Value = int.Parse(codigoReservaBox.Text);
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(function2);
                DataTable dtRecord = new DataTable();
                pagoReservaTable.DataSource = this.getReservas(int.Parse(codigoReservaBox.Text));

            }
            else
            {
                MessageBox.Show("No existe la reserva");

            }

        }




        public DataTable getReservas(Decimal codigoReserva)
        {

            SqlCommand cmd = Utils.Database.createCommand("MACACO_NOT_NULL.DetallesReserva");

            SqlParameter a_cod_reserva = cmd.Parameters.Add("@nombre_rol", SqlDbType.Decimal);

            //if (!Decimal.(codigoReserva))
                a_cod_reserva.Value = codigoReserva;
            //else
            //    a_cod_reserva.Value = DBNull.Value;


            return Utils.Database.getDataProcedure(cmd);
        }

        private void PagoReserva_Load(object sender, EventArgs e)
        {

        }



    }
}