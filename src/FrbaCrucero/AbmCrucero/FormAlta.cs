using FrbaCrucero.Model.Cruceros;
using FrbaCrucero.Utils;
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

        Crucero crucero = new Crucero();
        CruceroDAO cruceroDao = new CruceroDAO();
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

            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dgv_cabinas.Columns)
            {
                if(column.Index != 3)
                    dt.Columns.Add(column.DataPropertyName);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dgv_cabinas.Rows)
            {
                DataRow drow = dt.NewRow();
                drow["cabinas"] = int.Parse(row.Cells["cabinas"].Value.ToString());
                drow["piso"] = int.Parse(row.Cells["piso"].Value.ToString());
                drow["servicio"] = row.Cells["servicio"].ToString();
                dt.Rows.Add(drow);
            }
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].CreateOrUpdateCrucero");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = crucero.cruc_nombre;
            cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = crucero.cruc_modelo;
            cmd.Parameters.Add("@compania", SqlDbType.Int).Value = crucero.cruc_compañia_id;
            cmd.Parameters.Add("@cant_cabinas", SqlDbType.Int).Value = crucero.cruc_cantidad_cabinas;
            cmd.Parameters.Add("@fecha_alta", SqlDbType.DateTime2).Value = crucero.cruc_fecha_alta;
            cmd.Parameters.Add("@cabinas", SqlDbType.Structured).Value = dt;
            Database.executeProcedure(cmd);
            this.Close();
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
            var companias = cruceroDao.getCompaniasObj().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = cruceroDao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);

            var tipoServicios = cruceroDao.getTipoServicios().ToArray();
            cbo_tipo_servicio.Items.AddRange(tipoServicios);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            String tipoCabina = cbo_tipo_servicio.Text;
            String cantidad = txt_cantidad.Text;
            String piso = txt_piso.Text;
            dgv_cabinas.Rows.Add(tipoCabina,cantidad,piso);

            crucero.cruc_cantidad_cabinas += int.Parse(cantidad);
            txt_cabinas.Text = crucero.cruc_cantidad_cabinas.ToString();
            cbo_tipo_servicio.SelectedIndex = -1;
            txt_cantidad.Text = null;
            txt_piso.Text = null;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
          //LIMPIAR PANTALLA
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            crucero.cruc_fecha_alta = monthCalendar1.SelectionRange.Start;
            txt_fecha_alta.Text = crucero.cruc_fecha_alta.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_piso_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbo_compania_SelectionChangeCommitted(object sender, EventArgs e)
        {
            crucero.cruc_compañia_id = ((Compania)cbo_compania.SelectedItem).comp_id;
        }

        private void cbo_modelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            crucero.cruc_modelo = cbo_modelo.Text;

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            crucero.cruc_nombre = txt_nombre.Text;
        }

        private void txt_cabinas_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}


