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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("cabinas", System.Type.GetType("System.Int32"));
            dt.Columns.Add("piso", System.Type.GetType("System.Int32"));
            dt.Columns.Add("servicio", System.Type.GetType("System.String"));

            foreach (DataGridViewRow row in dgv_cabinas.Rows)
            {
                DataRow drow = dt.NewRow();
                drow["cabinas"] = int.Parse(row.Cells["cabinas"].Value.ToString());
                drow["piso"] = int.Parse(row.Cells["piso"].Value.ToString());
                drow["servicio"] = row.Cells["servicio"].Value.ToString();
                dt.Rows.Add(drow);
            }
            try
            {
                SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].CreateCrucero");
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = crucero.cruc_nombre;
                cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = crucero.cruc_modelo;
                cmd.Parameters.Add("@compania", SqlDbType.Int).Value = crucero.cruc_compañia_id;
                cmd.Parameters.Add("@cant_cabinas", SqlDbType.Int).Value = crucero.cruc_cantidad_cabinas;
                cmd.Parameters.Add("@fecha_alta", SqlDbType.DateTime2).Value = crucero.cruc_fecha_alta;
                cmd.Parameters.Add("@cabinas", SqlDbType.Structured).Value = dt;
                Database.executeProcedure(cmd);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            var companias = cruceroDao.getCompaniasObj().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = cruceroDao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);

            var tipoServicios = cruceroDao.getTipoServicios().ToArray();
            cbo_tipo_servicio.Items.AddRange(tipoServicios);

            var controls = group_box_crucero.Controls.Cast<Control>().Where(c => c is TextBox || c is ComboBox).ToList();
            
            controls.ForEach(c => {
                c.TextChanged += (sender2, e2) =>
                {
                    btn_guardar.Enabled = controls.All(c2 => !String.IsNullOrEmpty(c2.Text));
                };
            } );
           


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            String servicio = cbo_tipo_servicio.Text;
            String cantidad = txt_cantidad.Text;
            String piso = txt_piso.Text;

            var rows = dgv_cabinas.Rows.Cast<DataGridViewRow>().ToList();
            if (rows.Any(r => r.Cells["piso"].Value.Equals(piso) && r.Cells["servicio"].Value.Equals(servicio)))
                MessageBox.Show("Ya ingresó cabinas en el piso '" + piso +"' con el servicio '"+servicio+"'", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dgv_cabinas.Rows.Add(servicio, cantidad, piso);

                crucero.cruc_cantidad_cabinas += int.Parse(cantidad);
                txt_cabinas.Text = crucero.cruc_cantidad_cabinas.ToString();
                cbo_tipo_servicio.SelectedIndex = -1;
                txt_cantidad.Text = null;
                txt_piso.Text = null;
            }

           
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Controls.Cast<Control>().ToList()
                .Where(c => c is GroupBox)
                .SelectMany(c => c.Controls.Cast<Control>().ToList())
                .ToList().ForEach(c =>
                {
                    if (c is ComboBox)
                     ((ComboBox)c).SelectedIndex = -1;
                    if (c is TextBox)
                      c.Text = null;
                    if (c is DataGridView)
                        ((DataGridView)c).Rows.Clear();
                });

           /* 
            txt_nombre.Clear();
            cbo_modelo.SelectedIndex = -1;
            cbo_compania.SelectedIndex = -1;
            txt_cabinas.Clear();
            txt_fecha_alta.Clear();
            cbo_tipo_servicio.SelectedIndex = -1;
            txt_cantidad.Clear();
            txt_piso.Clear();
            dgv_cabinas.Rows.Clear();
            */
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            crucero.cruc_fecha_alta = monthCalendar1.SelectionRange.Start;
            txt_fecha_alta.Text = crucero.cruc_fecha_alta.Value.ToShortDateString();
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

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            crucero.cruc_nombre = txt_nombre.Text;
        }

        private void txt_cabinas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_modelo_TextChanged(object sender, EventArgs e)
        {
            crucero.cruc_modelo = cbo_modelo.Text;
        }

        private void cbo_tipo_servicio_TextChanged(object sender, EventArgs e)
        {
            btn_agregar.Enabled = new List<String>(new []{cbo_tipo_servicio.Text, txt_cantidad.Text, txt_piso.Text}).All(t => !String.IsNullOrEmpty(t));
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            btn_agregar.Enabled = new List<String>(new[] { cbo_tipo_servicio.Text, txt_cantidad.Text, txt_piso.Text }).All(t => !String.IsNullOrEmpty(t));
        }

        private void txt_piso_TextChanged(object sender, EventArgs e)
        {
            btn_agregar.Enabled = new List<String>(new[] { cbo_tipo_servicio.Text, txt_cantidad.Text, txt_piso.Text }).All(t => !String.IsNullOrEmpty(t));
        }

        private void dgv_cabinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_cabinas.Columns["eliminar"].Index)
            {
                int cantidad = Convert.ToInt32(dgv_cabinas["cabinas", e.RowIndex].Value);
                crucero.cruc_cantidad_cabinas -= cantidad;
                txt_cabinas.Text = crucero.cruc_cantidad_cabinas != 0 ? crucero.cruc_cantidad_cabinas.ToString() : null;
                dgv_cabinas.Rows.RemoveAt(e.RowIndex);
            }
                
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
