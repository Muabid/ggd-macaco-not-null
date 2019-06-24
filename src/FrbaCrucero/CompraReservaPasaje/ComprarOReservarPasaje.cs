using FrbaCrucero.AbmRecorrido;
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
        DateTime? salida;
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
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].GetViajes", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@viaj_fecha_salida", SqlDbType.DateTime2).Value = Database.orDbNull(salida);
                command.Parameters.Add("@puertoOrigen", SqlDbType.NVarChar).Value = Database.orDbNull(origenComboBox.Text);
                command.Parameters.Add("@puertoDestino", SqlDbType.NVarChar).Value = Database.orDbNull(destinoComboBox.Text);
                //Database.orDbNull(this.monthCalendar.SelectionRange.Start);
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
            monthCalendar.Visible = true;
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
            salida = null;

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
            if (e.ColumnIndex == dataGridViewViajes.Columns["ButtonSelection"].Index)
            {
                var id = int.Parse(dataGridViewViajes["viaj_crucero_id", e.RowIndex].Value.ToString());
                new ElegirCabinas().ShowDialog(this, id);
            }
            else if (e.ColumnIndex == dataGridViewViajes.Columns["verRecorridoButton"].Index)
            {
                var codigo = Convert.ToDecimal(dataGridViewViajes["recorridoColumn",e.RowIndex].Value);
                new RecorridoForm().Show(this, codigo);
            }

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar.SelectionStart >= DateTime.Today)
            {
                salida = monthCalendar.SelectionStart;
                salidaText.Text = salida.Value.ToShortDateString();
                monthCalendar.Visible = false;
            }
            
        }
    }
}
