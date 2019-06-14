using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           /* copié la logica del boton guardar recorrido y ahora
            * tengo que ir cambiando las variables para el ALTA CRUCERO
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

            */ 
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
          /* ASI FUNCIONABA ANTES
           * TENGO QUE VER COMO LO REEMPLAZO PARA USAR LA CLASE UTILS.DATABASE
           * 
            /// INSTANCIAR LA CLASE UBIGEO
            var ubigeo = new Model.Cruceros.Ubigeo();
            var tabla = ubigeo.ListarModelos();
            var tabla1 = ubigeo.ListarCompanias();

            if (tabla.Rows.Count > 0)
            {
                cbo_modelo.DataSource = tabla;
                cbo_modelo.DisplayMember = "cruc_modelo";
                cbo_modelo.ValueMember = "";
            }

            if (tabla1.Rows.Count > 0)
            {
                cbo_compania.DataSource = tabla1;
                cbo_compania.DisplayMember = "comp_nombre";
                cbo_modelo.ValueMember = "";
            }
           */
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

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
        }
    }
}


