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
        }


        
        private void origenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.AltaRol");
            //procedure.Parameters.Add("@nombre_rol", SqlDbType.NVarChar).Value = NombreNuevoRol.Text;
            //procedure.Parameters.Add("@activo", SqlDbType.Bit).Value = 1;
            //Utils.Database.executeProcedure(procedure);

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

        }
    }
}
