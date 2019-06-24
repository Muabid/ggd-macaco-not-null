using FrbaCrucero.Utils;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void txt_dni_LostFocus(object sender, System.EventArgs e)
        {
            MessageBox.Show("hola");            
        }

        private void clientesConDNI(string dni)
        {
            //DataTable dataTable = new DataTable();
            //using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].UsuariosConDNI", Database.getConnection()))
            //using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Decimal));
            //    command.Parameters["@dni"].Value = System.Convert.ToDecimal(dni);            
            //    try
            //    {
            //        dataAdapter.Fill(dataTable);
            //    }
            //    catch (SqlException e)
            //    {
            //        throw new Exception(e.Message, e);
            //    }
            //}
            //return dataTable;
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
           //s dataGridUsuarios.DataSource = clientesConDNI(txt_dni.Text);

        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_dni.Text))
            {

                SqlCommand command = Database.createCommand(" select concat(usua_nombre ,' ' ,usua_apellido) as usua_nombre,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac from MACACO_NOT_NULL.USUARIO where usua_dni like '%" + txt_dni.Text + "%';");
                DataTable data = Database.getData(command);
                if (data.Rows.Count > 0)
                {
                    var usuario = data.Rows[0];
                    txt_nombre_apellido.Text = usuario["usua_nombre"].ToString();
                    txt_telefono.Text = usuario["usua_telefono"].ToString();
                    txt_mail.Text = usuario["usua_mail"].ToString();
                    txt_direccion.Text = usuario["usua_direccion"].ToString();
                    txt_fecha_alta.Text = usuario["usua_fecha_nac"].ToString();
                }
            }

        }

        private void txt_fecha_alta_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            txt_fecha_alta.Text = this.monthCalendar1.SelectionRange.Start.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pago form = new Pago();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva form2 = new Reserva();
            form2.Show();
        }

      ///  this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
     //
    }
}
