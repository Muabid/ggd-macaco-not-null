using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Utils;
namespace FrbaCrucero.AbmRol
{
    public partial class Baja : Form
    {   
       
        public Baja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            this.dataGridView2.DataSource = null;
            this.dataGridView2.Rows.Clear();

        }






        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

              
                string textboxValue = textBox1.Text;
                string query  = "";
                if(!String.IsNullOrEmpty(textboxValue))
                {
                    query = "SELECT rol_id,rol_nombre,rol_activo FROM [MACACO_NOT_NULL].[ROL]" +
                               "WHERE rol_nombre LIKE '%" + textboxValue + "%'";
                    SqlCommand sql = Utils.Database.createCommand(query);
                    dataGridView2.DataSource = Database.getData(sql);

                }
                else
                {
                    MessageBox.Show("No se encontro el rol");
                               
                }

                
               

                
                //dataGridView2.ReadOnly = false;
                //dataGridView2.Columns[0].ReadOnly = true;
                //dataGridView2.Columns[1].ReadOnly = true;
                Boolean str = this.prueba();
                //Integer a = dataGridView2.Columns[0].DataGridView.Rows[0].ToString;
               // str =(Boolean) dataGridView2.Rows[dataGridView2.SelectedRows[2].Index].Cells[2].Value;
              //  Boolean a = this.dataGridView2_CellContentClick(dataGridView2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }

        

        private Boolean prueba(){
            if (dataGridView2.Rows.Count == 0)
                return false;
            Boolean item = (Boolean)dataGridView2.Rows[0].Cells[2].Value;
            return item;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean str = this.prueba();
            if (str)
            {
               /* SqlCommand procedure1 = Utils.Database.createCommand("MACACO_NOT_NULL.AltaRol");
                procedure1.Parameters.Add("@nombre_rol", SqlDbType.VarChar).Value = textBox1.Text;
                procedure1.Parameters.Add("@activo", SqlDbType.Bit).Value = str;
                Utils.Database.executeProcedure(procedure1);   */
                MessageBox.Show("No cambio nada");

                
            }
            else
            {
                String query = "select rol_id from MACACO_NOT_NULL.ROL where rol_nombre = ";

                SqlCommand procedure2 = Utils.Database.createCommand(query + "'" + textBox1.Text + "';");
                int resultado = Utils.Database.executeScalar(procedure2);
                
                SqlCommand procedure3 = Utils.Database.createCommand("MACACO_NOT_NULL.BajaRol");
                procedure3.Parameters.Add("@rol_id", SqlDbType.Int).Value = resultado;
                Utils.Database.executeProcedure(procedure3);
                MessageBox.Show("Baja realizada");

            } 


        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
