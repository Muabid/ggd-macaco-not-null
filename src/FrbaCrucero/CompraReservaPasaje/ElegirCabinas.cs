using FrbaCrucero.Model.Cruceros;
using FrbaCrucero.Model.TipoServicio;
using FrbaCrucero.Model.Viajes;
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
    public partial class ElegirCabinas : Form
    {
        private TipoServicioDAO tipoServicioDao = new TipoServicioDAO();
        Viaje viaje;
        public ElegirCabinas(Viaje viaje)
        {
            InitializeComponent();
            var tiposServicio = tipoServicioDao.getTiposServicios();
            foreach (FrbaCrucero.Model.TipoServicio.TipoServicio tipoServicio in tiposServicio)
            {
                cbo_tipo_servicio.Items.Add(tipoServicio);                
            }
            this.viaje = viaje;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].ObtenerCabinasDelCrucero", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@viajeId", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@piso", SqlDbType.Decimal));
                command.Parameters.Add(new SqlParameter("@tipo_servicio", SqlDbType.NVarChar));
                command.Parameters["@viajeId"].Value = viaje.id;
                command.Parameters["@piso"].Value = Database.orDbNull(txt_piso.Text);
                command.Parameters["@tipo_servicio"].Value = Database.orDbNull(cbo_tipo_servicio.Text);
               
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException error)
                {
                    throw new Exception(error.Message, error);
                }
            }
            dataGridViewCabinasDisponibles.DataSource = dataTable;

        }

        private void dataGridViewCabinasDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == dataGridViewCabinasDisponibles.Columns["agregar"].Index  )
            {
                object[] new_row = new object[4];
                new_row[0] = dataGridViewCabinasDisponibles["servicio1", e.RowIndex].Value;
                new_row[1] = dataGridViewCabinasDisponibles["cabi_id", e.RowIndex].Value;
                new_row[2] = dataGridViewCabinasDisponibles["cabi_nro", e.RowIndex].Value;
                new_row[3] = dataGridViewCabinasDisponibles["cabi_piso", e.RowIndex].Value;
                //dataGridViewCabinasReservadas.Rows.Add(new_row);


                Boolean found = false;
                foreach (DataGridViewRow row in dataGridViewCabinasReservadas.Rows)
                {
                    if (row.Cells[1].Value.ToString() == new_row[1].ToString())
                    {
                        
                        found = true;
                        MessageBox.Show("La cabina ya fue ingresada");
                        break;
                    }
                }

                if (!found)
                {
                    dataGridViewCabinasReservadas.Rows.Add(new_row); 
                }
            }
        }

        private void dataGridViewCabinasReservadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCabinasReservadas.Columns["eliminar"].Index)
            {               
                dataGridViewCabinasReservadas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void ElegirCabinas_Load(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> cabinasId = new List<int>();
            List<Cabina> cabinasElegidas = new List<Cabina>();
            foreach (DataGridViewRow item in dataGridViewCabinasReservadas.Rows)
            {
                cabinasId.Add((int)item.Cells[1].Value);
                Cabina cabina = new Cabina((int)item.Cells[1].Value, (String)item.Cells[0].Value, (Decimal)item.Cells[2].Value, (Decimal)item.Cells[3].Value); // id, tipoServicio, nro, piso
                cabinasElegidas.Add(cabina);
            }
           
           // DataTable data = (DataTable)(dataGridViewCabinasReservadas.DataSource);
            ClienteForm form = new ClienteForm(cabinasElegidas, viaje);
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompraReservaPasaje.ComprarOReservarPasaje gorm = new ComprarOReservarPasaje();
            gorm.Show();
            this.Close();
        }
    }
}
