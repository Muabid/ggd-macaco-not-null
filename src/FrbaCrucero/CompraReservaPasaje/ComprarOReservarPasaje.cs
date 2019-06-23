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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class ComprarOReservarPasaje : Form
    {
        CruceroDAO cruce = new CruceroDAO();
        VScrollBar vScroller = new VScrollBar();  

        private PuertoDAO puertoDao = new PuertoDAO();


        public ComprarOReservarPasaje()
        {
            InitializeComponent();
            var puertos = puertoDao.getPuertos();
            foreach (Puerto puerto in puertos)
            {
                origenComboBox.Items.Add(puerto);
                destinoComboBox.Items.Add(puerto);
            }


          
            vScrollBar1.Dock = DockStyle.Right; vScrollBar1.Scroll += (sender, e) => { this.VerticalScroll.Value = vScrollBar1.Value; }; 
            this.Controls.Add(vScrollBar1);


        }


        
        private void origenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {           
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].GetViaje", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@viaj_fecha_salida", SqlDbType.DateTime2));
                command.Parameters.Add(new SqlParameter("@puertoOrigen", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@puertoDestino", SqlDbType.NVarChar));
                command.Parameters["@viaj_fecha_salida"].Value = this.monthCalendar.SelectionRange.Start;
                if (origenComboBox.SelectedItem == null)
                {
                    command.Parameters["@puertoOrigen"].Value = "";
                }
                else
                {
                    command.Parameters["@puertoOrigen"].Value = origenComboBox.SelectedItem.ToString();
                }
                if (destinoComboBox.SelectedItem == null)
                {
                    command.Parameters["@puertoDestino"].Value = "";
                }
                else
                {
                    command.Parameters["@puertoDestino"].Value = destinoComboBox.SelectedItem.ToString();
                }
                // command.Parameters["@viaj_fecha_salida"].Value = null;
               // command.Parameters["@puertoDestino"].Value = null;
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException error)
                {
                    throw new Exception(error.Message, error);
                }
            }
            dataGridViewViajes.DataSource = dataTable;

        }

        private void btn_seleccionar_salida_Click(object sender, EventArgs e)
        {
            salidaText.Text = this.monthCalendar.SelectionRange.Start.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }


            this.destinoComboBox.SelectedIndex = -1;
            this.origenComboBox.SelectedIndex = -1;
            salidaText.Text = String.Empty;

        }

        private void ComprarOReservarPasaje_Load(object sender, EventArgs e)
        {

            var tipoServicios = cruce.getTipoServicios().ToArray();
          //  cbo_tipo_servicio.Items.AddRange(tipoServicios);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void cbo_tipo_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
