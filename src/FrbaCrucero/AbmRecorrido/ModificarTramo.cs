using FrbaCrucero.Model.Recorridos;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificarTramo : Form
    {
        private ModificacionRecorrido modificarRecorrido;
        private PuertoDAO puertoDao = new PuertoDAO();
        int? rowIndex;
        public ModificarTramo(ModificacionRecorrido _modificarRecorrido)
        {
            InitializeComponent();
            var puertos = puertoDao.getPuertos();
            foreach (Puerto puerto in puertos)
            {
                origenCombo.Items.Add(puerto);
                destinoCombo.Items.Add(puerto);
            }
            modificarRecorrido = _modificarRecorrido;
        }

        public void Show(String ciudadOrigen, String ciudadDestino, Decimal precio, int _rowIndex)
        {
            origenCombo.SelectedIndex = origenCombo.FindStringExact(ciudadOrigen);
            destinoCombo.SelectedIndex = destinoCombo.FindStringExact(ciudadDestino);
            precioText.Text = precio.ToString();
            rowIndex = _rowIndex;
            this.ShowDialog();
        }


        public void Show()
        {
            this.ShowDialog();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            modificarRecorrido.updateTramos((Puerto)origenCombo.SelectedItem,
                (Puerto)destinoCombo.SelectedItem,Convert.ToDecimal(precioText.Text), rowIndex);
            this.Close();
        }

        private void precioText_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
