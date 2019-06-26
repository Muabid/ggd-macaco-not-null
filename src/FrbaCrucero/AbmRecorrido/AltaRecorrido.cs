using FrbaCrucero.Model.Recorridos;
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
namespace FrbaCrucero.AbmRecorrido
{
    public partial class AltaRecorrido : Form
    {
        private AltaTramo altaTramo;
        private RecorridoDAO recorridosDao = new RecorridoDAO();
        public AltaRecorrido()
        {
            InitializeComponent();
            altaTramo = new AltaTramo(this); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onAgregarTramo(object sender, EventArgs e)
        {
            altaTramo.show();
        }

        public void addTramo(Tramo tramo)
        {
            tramosTable.Rows.Add(tramo.ciudadOrigen, tramo.ciudadDestino, tramo.precio);
        }

        public Puerto getProximoOrigenPuerto()
        {
            int index = tramosTable.Rows.Count-1;
            if (index < 0)
                return null;
            else
                return (Puerto)tramosTable.Rows[index].Cells[1].Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ciudadOrigen");
                    dt.Columns.Add("ciudadDestino");
                    DataColumn column;
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.Decimal");
                    column.ColumnName = "precio";
                    dt.Columns.Add(column);
                    dt.Columns.Add("indice");
                    dt.Columns.Add("tramoId");
                    foreach (DataGridViewRow row in tramosTable.Rows)
                    {
                        Puerto origen = (Puerto)row.Cells[0].Value;
                        Puerto destino = (Puerto)row.Cells[1].Value;
                        DataRow dRow = dt.NewRow();
                        if (origen != null && destino != null)
                        {
                            Decimal precio = decimal.Parse(row.Cells[2].Value.ToString());
                            dRow[0] = origen.id;
                            dRow[1] = destino.id;
                            dRow[2] = precio;
                            dRow[3] = row.Index;
                            dt.Rows.Add(dRow);

                        }

                    }
                    recorridosDao.insertRecorrido(Convert.ToDecimal(codigo.Text), dt);
                    MessageBox.Show("Recorrido: "+codigo.Text + " dado de alta.", "Operación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_Click(null, null);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.tramosTable.Rows.Clear();
            this.tramosTable.Refresh();
            this.codigo.Clear();
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            if (validateCodigo())
            {
                e.Cancel = false;
                codigo.Focus();
                codigoError.SetError(this.codigo, String.Empty);
            }
            else
            {
                e.Cancel = true;
                codigoError.SetError(this.codigo, "Ingrese el código");
            }
        }

        private bool validateCodigo()
        {
            return !String.IsNullOrEmpty(codigo.Text);
        }

        private void tramosTable_Validating(object sender, CancelEventArgs e)
        {
            if (validateTramos())
            {
                e.Cancel = false;
                tramosError.SetError(this.tramosTable, String.Empty);
            }
            else
            {
                e.Cancel = true;
                tramosError.SetError(this.tramosTable, "Debe ingresar al menos un tramo");
            }
        }

        private bool validateTramos()
        {
            return tramosTable.Rows.Count >= 1;
        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
