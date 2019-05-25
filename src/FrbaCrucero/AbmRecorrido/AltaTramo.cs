using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Utils;
using System.Data.SqlClient;
using FrbaCrucero.Model.Recorridos;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AltaTramo : Form
    {
        private PuertoDAO puertoDao = new PuertoDAO();
        private AltaRecorrido altaRecorrido;


        public AltaTramo(AltaRecorrido altaRecorrido)
        {
            InitializeComponent();
            var puertos = puertoDao.getPuertos();
            foreach(Puerto puerto in puertos){
                origenComboBox.Items.Add(puerto);
                destinoComboBox.Items.Add(puerto);
            }
            this.altaRecorrido = altaRecorrido;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void origen_TextUpdate(object sender, EventArgs e)
        {
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void onGuardar(object sender, EventArgs e)
        {
            Puerto origen = (Puerto)origenComboBox.SelectedItem;
            Puerto destino = (Puerto)destinoComboBox.SelectedItem;
            Decimal precio = Convert.ToDecimal(precioField.Text);
            altaRecorrido.addTramo(new Tramo(precio,origen,destino));
            this.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void precioField_TextChanged(object sender, EventArgs e)
        {

        }

        public void show()
        {
            this.ShowDialog();
            Puerto puertoOrigen = altaRecorrido.getProximoOrigenPuerto();
            Console.WriteLine(puertoOrigen);
            if (puertoOrigen != null)
            {
                origenComboBox.SelectedItem = puertoOrigen;
                origenComboBox.Enabled = false;
            }
        }
    }
}
