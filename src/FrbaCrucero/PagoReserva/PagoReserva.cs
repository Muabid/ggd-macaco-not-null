using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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


            if (pagoReservaTable.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MediosDePago nuevo = new MediosDePago(codigoReservaBox.Text);
                nuevo.Show(this);
                this.Hide();
            }

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
            DataTable table = this.pagoReservaTable.DataSource as DataTable;

            if (table != null)
            {
               table.Clear();//arreglar error 
                this.pagoReservaTable.Refresh();
            }

        }

        private void botonBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = Utils.Database.createCommand("SELECT  MACACO_NOT_NULL.ComprobarExistenciaReserva(@codigo)");

                SqlParameter value = new SqlParameter("@codigo", SqlDbType.Decimal);
                

                if(String.IsNullOrEmpty(codigoReservaBox.Text))
                {
                    throw new Exception("Ingrese un codigo de reserva");
                }
                value.Value = Decimal.Parse(codigoReservaBox.Text);

                cmd.Parameters.Add(value);

                int resultado = Utils.Database.executeScalar(cmd);


                if (resultado == 1)
                {
                    Decimal codigo = Decimal.Parse(codigoReservaBox.Text);
                    SqlCommand sp = Utils.Database.createCommand("[MACACO_NOT_NULL].ComprobarVigenciaReserva");
                    sp.Parameters.Add("@codigo_reserva", SqlDbType.Decimal).Value = codigo;
                    sp.Parameters.Add("@fecha_sistema", SqlDbType.DateTime2).Value = DateTime.Parse(ConfigurationManager.AppSettings.Get("DATE"));
                    pagoReservaTable.DataSource = this.getReservas(codigo);

                }
                else
                {
                    MessageBox.Show("No existe la reserva");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }




        public DataTable getReservas(Decimal codigoReserva)
        {
            SqlCommand cmd = Utils.Database.createCommand("SELECT DISTINCT * FROM  MACACO_NOT_NULL.DetallesReserva(@codigo_reserva)");

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

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void codigoReservaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



    }
}