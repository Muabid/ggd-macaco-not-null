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

namespace FrbaCrucero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRol.InicioRol fm1 = new AbmRol.InicioRol();
            this.Hide();
            fm1.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = Utils.Database.getConnection();
            connection.Open();
            MessageBox.Show("Connection Open  !");
            
        }
    }
}
