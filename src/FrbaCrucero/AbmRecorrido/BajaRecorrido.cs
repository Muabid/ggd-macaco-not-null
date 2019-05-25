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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class BajaRecorrido : Form
    {
        public BajaRecorrido()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void onBuscar(object sender, EventArgs e)
        {
            SqlCommand command = Database.createCommand("MACACO_NOT_NULL.getRecorridos");
            command.CommandType = CommandType.StoredProcedure;
            dataGridView1.DataSource = Database.getData(command);
        }
    }
}
