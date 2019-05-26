using FrbaCrucero.Model.Recorridos;
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

        private RecorridoDAO recorridoDao = new RecorridoDAO();
        public BajaRecorrido()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void onBuscar(object sender, EventArgs e)
        {
            
            String codigo = codigoField.Text;
            String origen = (String)ciudadOrigenCombo.SelectedValue;
            String destino = (String)ciudadDestinoCombo.SelectedValue;
            recorridosTable.DataSource = recorridoDao.getRecorridos(codigo,origen,destino);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
