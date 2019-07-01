using FrbaCrucero.AbmRecorrido;
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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionRecorrido : Form
    {
        private RecorridoDAO recorridoDao = new RecorridoDAO();
        private PuertoDAO puertoDao = new PuertoDAO();
        GenerarViaje generarViaje;
        public SeleccionRecorrido(GenerarViaje _generarViaje)
        {
            InitializeComponent();
            generarViaje = _generarViaje;
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                ciudadOrigenCombo.Items.Add(puerto.nombre);
            }
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                ciudadDestinoCombo.Items.Add(puerto.nombre);
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            String codigo = codigoBox.Text;
            String origen = (String)ciudadOrigenCombo.SelectedItem;
            String destino = (String)ciudadDestinoCombo.SelectedItem;

            recorridosTable.DataSource = recorridoDao.getRecorridos(codigo, origen, destino);
        }

        private void recorridosTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Decimal codRecorrido = Convert.ToDecimal(recorridosTable["codigoColumn", e.RowIndex].Value);
            if (e.ColumnIndex == recorridosTable.Columns["verColumn"].Index)
            {

                Decimal precio = Convert.ToDecimal(recorridosTable["precioColumn", e.RowIndex].Value);
                new RecorridoForm().show(codRecorrido, precio);
            }
            else if (e.ColumnIndex == recorridosTable.Columns["seleccionarColumn"].Index)
            {
                int id = Convert.ToInt32(recorridosTable["id", e.RowIndex].Value);
                Decimal codigo = Convert.ToDecimal(recorridosTable["codigoColumn", e.RowIndex].Value);
                generarViaje.updateRecorrido(new Recorrido(id,codigo));
                this.Close();
            }
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.recorridosTable.DataSource;
            if (dt != null)
                dt.Clear();
            this.codigoBox.Clear();
            this.ciudadDestinoCombo.SelectedIndex = -1;
            this.ciudadOrigenCombo.SelectedIndex = -1;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
