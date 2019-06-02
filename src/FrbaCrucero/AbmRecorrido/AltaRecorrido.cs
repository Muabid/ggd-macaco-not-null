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
            int index = tramosTable.Rows.Count-2;
            if (index < 0)
                return null;
            else
                return (Puerto)tramosTable.Rows[index].Cells[1].Value;
        }

      /*  private void saveButton_Click(object sender, EventArgs e)
        {
            List<Tramo> tramos = new List<Tramo>();
            foreach (DataGridViewRow row in tramosTable.Rows)
            {
                Puerto origen = (Puerto)row.Cells[0].Value;
                Puerto destino =(Puerto)row.Cells[1].Value;
                Decimal precio = Convert.ToDecimal(row.Cells[2].Value);
                tramos.Add(new Tramo(precio,origen,destino));
            }
           recorridosDao.insertRecorrido(Convert.ToDecimal(code.Text),tramos);
        }*/
        private void saveButton_Click(object sender, EventArgs e)
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
            MessageBox.Show("Se dio de alta el recorrido" + codigo.Text, "Operacion exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.tramosTable.Rows.Clear();
            this.tramosTable.Refresh();
            this.codigo.Clear();
        }

    }
}
