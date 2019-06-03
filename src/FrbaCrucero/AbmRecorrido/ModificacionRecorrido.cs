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
    public partial class ModificacionRecorrido : Form
    {

        private RecorridoDAO recorridoDao = new RecorridoDAO();
        private PuertoDAO puertoDao = new PuertoDAO();
        private ListadoModificacionRecorrido listadoRecorridos;

        public ModificacionRecorrido(ListadoModificacionRecorrido _listadoRecorridos)
        {
            InitializeComponent();
            listadoRecorridos = _listadoRecorridos;
        }


        public void show(Decimal codigoRecorrido, Decimal precio)
        {
            tramosTable.DataSource = recorridoDao.getTramos(codigoRecorrido);
            codigoText.Text = codigoRecorrido.ToString();
            precioText.Text = precio.ToString();
            this.ShowDialog();

        }

        private void tramosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == tramosTable.Columns["modificarColumn"].Index)
            {
                String origen = (String)tramosTable["origenColumn", e.RowIndex].Value;
                String destino = (String)tramosTable["destinoColumn", e.RowIndex].Value;
                Decimal precio = (Decimal)tramosTable["precioColumn", e.RowIndex].Value;
                new ModificarTramo(this).Show(origen, destino, precio, e.RowIndex);
            }
            else if (e.ColumnIndex == tramosTable.Columns["borrarColumn"].Index) 
            {
                if(tramosTable.Rows.Count -1 >0)
                    tramosTable.Rows.RemoveAt(e.RowIndex);
                else
                    MessageBox.Show("Recorrido sin tramos", "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateTramos(Puerto p1, Puerto p2, decimal p3, int? tramoIndex)
        {
            if (tramoIndex != null)
            {
                foreach (DataGridViewRow row in tramosTable.Rows)
                {   
                    if (int.Equals(row.Index,tramoIndex))
                    {
                        row.Cells["origenColumn"].Value = p1.nombre;
                        row.Cells["destinoColumn"].Value = p2.nombre;
                        row.Cells["precioColumn"].Value = p3;
                    }
                        
                }
            }
            else
            {
                DataTable dt2 = tramosTable.DataSource as DataTable; 
                DataRow datarow = dt2.NewRow();
                datarow["desde"] = p1.nombre;
                datarow["hasta"] = p2.nombre;
                datarow["precio"] = p3;
                dt2.Rows.Add(datarow);
            }
          
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Decimal codigoRecorrido = Convert.ToDecimal(codigoText.Text);
            tramosTable.DataSource = recorridoDao.getTramos(codigoRecorrido);
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                this.validateTramos();
               
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
                   
                        Puerto origen = puertoDao.getPuertoByName((String)row.Cells["origenColumn"].Value);
                        Puerto destino = puertoDao.getPuertoByName((String)row.Cells["destinoColumn"].Value);
                        Decimal precio = decimal.Parse(row.Cells["precioColumn"].Value.ToString());
                        DataRow dRow = dt.NewRow();
                        
                        dRow[0] = origen.id;
                        dRow[1] = destino.id;
                        dRow[2] = precio;
                        dRow[3] = row.Index;
                        dRow[4] = row.Cells["tramoId"].Value;
                        dt.Rows.Add(dRow);

                }
                recorridoDao.modificarRecorrido(Convert.ToDecimal(codigoText.Text), dt);
                MessageBox.Show("Recorrido modificado con éxito", "Operación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                listadoRecorridos.Refresh();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void validateTramos()
        {
            for (int i = 0; i < tramosTable.Rows.Count - 2; i++)
            {
                DataGridViewRow row1 = tramosTable.Rows[i];
                DataGridViewRow row2 = tramosTable.Rows[i+1];

                if (!row1.Cells["destinoColumn"].Value.Equals(row2.Cells["origenColumn"].Value))
                    throw new Exception("Hay puertos desconectados");
            }
        }

        private void agregarTramoButton_Click(object sender, EventArgs e)
        {
            new ModificarTramo(this).Show();
        }

       
    }
}
