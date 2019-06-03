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
            if (ValidateChildren())
            {
                Puerto origen = (Puerto)origenComboBox.SelectedItem;
                Puerto destino = (Puerto)destinoComboBox.SelectedItem;
                Decimal precio = Convert.ToDecimal(precioField.Text);
                altaRecorrido.addTramo(new Tramo(precio, origen, destino));
                destinoComboBox.SelectedIndex = -1;
                this.Close();
            }
            
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
            if (puertoOrigen != null)
            {
                origenComboBox.SelectedItem = puertoOrigen;
                origenComboBox.Enabled = false;
            }
        }

        private void precioField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void origenComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (origenComboBox.SelectedItem != null)
            {
                e.Cancel = false;
                errorProvider.SetError(this.origenComboBox, String.Empty);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(this.origenComboBox, "Ingrese un origen");
            }
        }

        private void destinoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destinoComboBox.SelectedItem != null)
            {
                e.Cancel = false;
                errorProvider.SetError(this.destinoComboBox, String.Empty);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(this.destinoComboBox, "Ingrese un destino");
            }
        }

        private void precioField_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(precioField.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(this.precioField, String.Empty);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(this.precioField, "Ingrese un precio");
            }
        }
        
    }
}
