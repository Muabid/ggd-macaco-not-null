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

        private object clientesConDNI(string dni)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].UsuariosConDNI", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Decimal));
                command.Parameters["@dni"].Value = System.Convert.ToDecimal(dni);            
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            return dataTable;
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
           //s dataGridUsuarios.DataSource = clientesConDNI(txt_dni.Text);

        }

      ///  this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
     //
    }
}
